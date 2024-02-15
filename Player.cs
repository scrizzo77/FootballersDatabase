using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteTest
{
	class Player // base class (parent)
	{
		public string name;
		public int age;
		public string country;

		public Player(string name, int age, string country)
		{
			this.name = name;
			this.age = age;
			this.country = country;
		}
		public void AddData(SQLiteConnection connection)
		{

		}
		public void UpdateData(SQLiteConnection connection)
		{

		}
		public void DeleteData(SQLiteConnection connection)
		{

		}
	}
}
