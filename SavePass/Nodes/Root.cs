using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SavePass.Nodes
{
	/// <summary>
	/// Коллекция класса Entry
	/// </summary>
	[DataContract]
	public class Root : IComparable<Root>, IEnumerable<Entry>
	{
		/// <summary>
		/// Список полей
		/// </summary>
		[DataMember(Name = "Entries")]
		private List<Entry> _entries;

		/// <summary>
		/// Имя базы данных
		/// </summary>
		[DataMember]
		public string Name { get; set; }

		/// <summary>
		/// Индексатор класса Entry
		/// </summary>
		/// <param name="key">Имя записи</param>
		/// <returns></returns>
		public Entry this[string key]
		{
			get
			{
				foreach (var item in _entries)
				{
					if (key == item.Name)
					{
						return item;
					}
				}
				return null;
			}
		}

		/// <summary>
		/// Инициализирует класс Root с заданным именем
		/// </summary>
		/// <param name="name">имя базы данных</param>
		public Root(string name)
		{
			Name = name;
			_entries = new List<Entry>();
		}

		/// <summary>
		/// Инициализирует класс Root с заданным именем и заданной коллекцией класса Entry
		/// </summary>
		/// <param name="name">имя базы данных</param>
		/// <param name="collection">коллекция класса Entry</param>
		public Root(string name, IEnumerable<Entry> collection) : this(name)
		{
			_entries.AddRange(collection);
		}

		/// <summary>
		/// Добавляет запись в базу данных
		/// </summary>
		/// <param name="item">класс Entry</param>
		public void Add(Entry item)
		{
			string name = item.Name;
			for (int i = 2; this[item.Name] != null; i++)
			{
				item.Name = string.Format("{0} ({1})", name, i);
			}
			_entries.Add(item);
			_entries.Sort();
		}

		/// <summary>
		/// Удаляет запись с базы данных
		/// </summary>
		/// <param name="item">класс Entry</param>
		public bool Remove(Entry item)
		{
			return _entries.Remove(item);
		}

		public void Sort()
		{
			_entries.Sort();
		}

		/// <summary>
		/// Сравнивает данный экземпляр с объектом Root и показывает, расположен ли данный экземпляр перед, до или на той же позициив порядке сортировки, что и заданный объект Root
		/// </summary>
		/// <param name="other">объект, имеющий значение Root</param>
		/// <returns>32-битовое целое число со знаком, которое показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и параметр</returns>
		public int CompareTo(Root other)
		{
			return Name.CompareTo(other.Name);
		}


		/// <summary>
		/// Возвращает перечислитель, осуществляющий перебор элементов списка _entries
		/// </summary>
		public IEnumerator<Entry> GetEnumerator()
		{
			return _entries.GetEnumerator();
		}

		/// <summary>
		/// Возвращает перечислитель, осуществляющий перебор элементов списка _entries
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}