using System;
using SavePass.Exceptions;

namespace SavePass.Nodes
{
	/// <summary>
	/// Заголовок файла
	/// </summary>
	public class Header
	{
		private static Random _rand = new Random();

		/// <summary>
		/// Сигнатура программы
		/// </summary>
		public const uint BaseSignature = 0x1C8D7D4A;

		/// <summary>
		/// Сигнатура версии
		/// </summary>
		public const uint VersionSignature = 0x00010000;

		/// <summary>
		/// Соль
		/// </summary>
		public readonly byte[] MasterSeed;

		/// <summary>
		/// Инициализирует класс Header
		/// </summary>
		/// <param name="baseSignature">cигнатура программы</param>
		/// <param name="versionSignature">cигнатура версии</param>
		/// <param name="masterSeed">соль</param>
		public Header(uint baseSignature, uint versionSignature, byte[] masterSeed)
		{
			if (baseSignature != BaseSignature || versionSignature != VersionSignature)
			{
				throw new FileCorruptException();
			}
			MasterSeed = masterSeed;
		}

		/// <summary>
		/// Инициализирует класс Header
		/// </summary>
		public Header()
		{
			MasterSeed = new byte[8];
			_rand.NextBytes(MasterSeed);
		}
	}
}