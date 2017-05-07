using System;
using System.Runtime.Serialization;

namespace SavePass.Nodes
{
	/// <summary>
	/// Класс записи паролей
	/// </summary>
	[DataContract]
	public class Entry : IComparable<Entry>
	{
		/// <summary>
		/// Пароль в кодировке base64
		/// </summary>
		[DataMember(Name = "Password")]
		private string _passwordBase64;

		/// <summary>
		/// Имя записи
		/// </summary>
		[DataMember]
		public string Name { get; set; }


		/// <summary>
		/// Имя пользователя
		/// </summary>
		[DataMember]
		public string Username { get; set; }

		/// <summary>
		/// Пароль
		/// </summary>
		public string Password
		{
			get
			{
				return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(_passwordBase64));
			}
			set
			{
				_passwordBase64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
			}
		}

		/// <summary>
		/// Электронная почта
		/// </summary>
		[DataMember]
		public string Email { get; set; }

		/// <summary>
		/// Адрес веб-сайта
		/// </summary>
		[DataMember]
		public string Website { get; set; }

		/// <summary>
		/// Комментарии к записи
		/// </summary>
		[DataMember]
		public string Notes { get; set; }

		/// <summary>
		/// Инициализирует пустую запись с заданным именем
		/// </summary>
		/// <param name="entryName">имя записи</param>
		public Entry(string entryName)
		{
			Name = entryName;
			Username = "";
			_passwordBase64 = "";
			Email = "";
			Website = "";
			Notes = "";
		}

		/// <summary>
		/// Сравнивает данный экземпляр с объектом Entry и показывает, расположен ли данный экземпляр перед, до или на той же позициив порядке сортировки, что и заданный объект Entry
		/// </summary>
		/// <param name="other">объект, имеющий значение Entry</param>
		/// <returns>32-битовое целое число со знаком, которое показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и параметр</returns>
		int IComparable<Entry>.CompareTo(Entry other)
		{
			return Name.CompareTo(other.Name);
		}
	}
}