using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteTest
{
	class Footballer : Player
	{
		public string club;
		public string position;
		public int shirt_number;

		public Footballer(string name, int age, string country, string club, string position, int shirt_number) : base(name,age,country)
		{
			this.club = club;
			this.position = position;
			this.shirt_number = shirt_number;
		}

		private SQLiteCommand CreateSQLCommand(SQLiteConnection connection)
		{
			var cmd = new SQLiteCommand(connection);
			cmd.Parameters.AddWithValue("@Name", this.name);
			cmd.Parameters.AddWithValue("@Age", this.age);
			cmd.Parameters.AddWithValue("@Club", this.club);
			cmd.Parameters.AddWithValue("@Country", this.country);
			cmd.Parameters.AddWithValue("@Position", this.position);
			cmd.Parameters.AddWithValue("@Shirt_number", this.shirt_number);
			return cmd;
		}

		public void AddData(SQLiteConnection connection)
		{
			var cmd = CreateSQLCommand(connection);
			cmd.CommandText = "INSERT INTO tblFootballers(name,age,club,country,position,shirt_number) VALUES(@Name,@Age,@Club,@Country,@Position,@Shirt_number)";
			cmd.ExecuteNonQuery();
		}

		public void UpdateData(SQLiteConnection connection)
		{
			var cmd = CreateSQLCommand(connection);
			cmd.CommandText = "UPDATE tblFootballers SET age=@Age, club=@Club, country=@Country, position=@Position, shirt_number=@Shirt_number where name=@Name";
			cmd.ExecuteNonQuery();
		}
		public void DeleteData(SQLiteConnection connection)
		{
			var cmd = CreateSQLCommand(connection);
			cmd.CommandText = "DELETE FROM tblFootballers WHERE name = @Name";
			cmd.ExecuteNonQuery();
		}
	}
}
