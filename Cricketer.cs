using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteTest
{
	class Cricketer : Player
	{
		public string playingRole;
		public string battingStyle;
		public string bowlingStyle;

		public Cricketer(string name, int age, string country, string playingRole, string battingStyle, string bowlingStyle) : base(name, age, country)
		{
			this.playingRole = playingRole;
			this.battingStyle = battingStyle;
			this.bowlingStyle = bowlingStyle;
		}

		private SQLiteCommand CreateSQLCommand(SQLiteConnection connection)
		{
			var cmd = new SQLiteCommand(connection);
			cmd.Parameters.AddWithValue("@Name", this.name);
			cmd.Parameters.AddWithValue("@Age", this.age);
			cmd.Parameters.AddWithValue("@Country", this.country);
			cmd.Parameters.AddWithValue("@PlayingRole", this.playingRole);
			cmd.Parameters.AddWithValue("@BattingStyle", this.battingStyle);
			cmd.Parameters.AddWithValue("@BowlingStyle", this.bowlingStyle);
			return cmd;
		}
		public void AddData(SQLiteConnection connection)
		{
			var cmd = CreateSQLCommand(connection);
			cmd.CommandText = "INSERT INTO tblCricketers(name,age,country,playingRole,battingStyle,bowlingStyle) VALUES(@Name,@Age,@Country,@PlayingRole,@BattingStyle,@BowlingStyle)";
			cmd.ExecuteNonQuery();
		}
		public void UpdateData(SQLiteConnection connection)
		{
			var cmd = CreateSQLCommand(connection);
			cmd.CommandText = "UPDATE tblCricketers SET age=@Age, country=@Country, playingRole=@PlayingRole, battingStyle=@BattingStyle, bowlingStyle = @BowlingStyle where name=@Name";
			cmd.ExecuteNonQuery();
		}
		public void DeleteData(SQLiteConnection connection)
		{
			var cmd = CreateSQLCommand(connection);
			cmd.CommandText = "DELETE FROM tblCricketers WHERE name = @Name";
			cmd.ExecuteNonQuery();
		}

	}
}
