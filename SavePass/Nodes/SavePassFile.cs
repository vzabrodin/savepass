using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using SavePass.Crypto;
using SavePass.Exceptions;

namespace SavePass.Nodes
{
	public class SavePassFile
	{
		/// <summary>
		/// JSON-сериализатор
		/// </summary>
		private DataContractJsonSerializer _jsonFormatter = new DataContractJsonSerializer(typeof(Root));

		/// <summary>
		/// Заголовок файла
		/// </summary>
		private Header _header;

		/// <summary>
		/// Имя файла
		/// </summary>
		public string FileName { get; private set; }

		/// <summary>
		/// Пароль базы данных
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// База данных
		/// </summary>
		public Root Root { get; private set; }

		/// <summary>
		/// Инициализирует экземпляр класса SavePassFile
		/// </summary>
		public SavePassFile()
		{
		}

		/// <summary>
		/// Создаёт базы данных с заданным именем и паролем
		/// </summary>
		/// <param name="databaseName">имя базы данных</param>
		/// <param name="password">пароль базы данных</param>
		public void New(string databaseName, string password)
		{
			Close();
			Password = password;
			_header = new Header();
			Root = new Root(databaseName);
		}

		/// <summary>
		/// Открывает существующий файл SavePass
		/// </summary>
		/// <param name="filename">имя файла</param>
		/// <param name="password">пароль</param>
		public void Open(string filename, string password)
		{
			FileName = filename;
			Password = password;

			using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite))
			{
				using (BinaryReader binrd = new BinaryReader(stream))
				{
					uint baseSignature = binrd.ReadUInt32();
					uint versionSignature = binrd.ReadUInt32();
					byte[] masterSeed = binrd.ReadBytes(8);
					_header = new Header(baseSignature, versionSignature, masterSeed);
					byte[] jsonEncrypted = binrd.ReadBytes((int)(stream.Length - stream.Position));
					byte[] jsonDecrypted;
					try
					{
						jsonDecrypted = AES.AESDecrypt(jsonEncrypted, Encoding.Unicode.GetBytes(Password), masterSeed);
					}
					catch (System.Security.Cryptography.CryptographicException)
					{
						throw new WrongPasswordException();
					}
					using (MemoryStream ms = new MemoryStream(jsonDecrypted))
					{
						try
						{
							Root = (Root)_jsonFormatter.ReadObject(ms);
						}
						catch (Exception)
						{
							throw new FileCorruptException();
						}
					}
				}
			}
		}

		/// <summary>
		/// Сохраняет открытый файл
		/// </summary>
		public void Save()
		{
			using (Stream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
			{
				using (BinaryWriter binwr = new BinaryWriter(stream))
				{
					binwr.Write(Header.BaseSignature);
					binwr.Write(Header.VersionSignature);
					binwr.Write(_header.MasterSeed);
					byte[] jsonDecrypted, jsonEncrypted;
					using (MemoryStream ms = new MemoryStream())
					{
						_jsonFormatter.WriteObject(ms, Root);
						ms.Position = 0;
						jsonDecrypted = new byte[ms.Length];
						ms.Read(jsonDecrypted, 0, (int)ms.Length);
					}
					jsonEncrypted = AES.AESEncrypt(jsonDecrypted, Encoding.Unicode.GetBytes(Password), _header.MasterSeed);
					binwr.Write(AES.AESEncrypt(jsonDecrypted, Encoding.Unicode.GetBytes(Password), _header.MasterSeed));
				}
			}
		}

		/// <summary>
		/// Сохраняет открытый файл с указанных путём файла
		/// </summary>
		public void Save(string filename)
		{
			FileName = filename;
			Save();
		}

		/// <summary>
		/// Закрывает открытый файл
		/// </summary>
		public void Close()
		{
			FileName = null;
			Root = null;
		}
	}
}