using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteTest
{
	public partial class Form1 : Form
	{
		//path of data base
		static string dbpath = "C:\\Users\\Aditya.DESKTOP-EEN8D20\\Desktop\\Me\\Python\\Python challenges\\Databases\\Sports.db";
		string cs = @"URI=file:" + dbpath;

		SQLiteConnection con;
		SQLiteCommand cmd;
		SQLiteDataReader dr;

		public Form1()
		{
			InitializeComponent();
			
		}
		//show data in table
		private void footballdata_show()
		{
			var con = new SQLiteConnection(cs);
			con.Open();
			dataGridView1.Rows.Clear();

			string stm = "SELECT * FROM tblFootballers";
			var cmd = new SQLiteCommand(stm, con);
			dr = cmd.ExecuteReader();

			dataGridView1.Columns[0].HeaderText = "Name";
			dataGridView1.Columns[1].HeaderText = "Age";
			dataGridView1.Columns[2].HeaderText = "Club";
			dataGridView1.Columns[3].HeaderText = "Country";
			dataGridView1.Columns[4].HeaderText = "Position";
			dataGridView1.Columns[5].HeaderText = "Shirt number";

			while (dr.Read())
			{
				string[] row = new string[] { dr.GetString(0), dr.GetInt32(1).ToString(), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5).ToString()};
				dataGridView1.Rows.Add(row);
			}
		}

		private void cricketdata_show()
		{
			var con = new SQLiteConnection(cs);
			con.Open();
			dataGridView1.Rows.Clear();

			string stm = "SELECT * FROM tblCricketers";
			var cmd = new SQLiteCommand(stm, con);
			dr = cmd.ExecuteReader();

			dataGridView1.Columns[0].HeaderText = "Name";
			dataGridView1.Columns[1].HeaderText = "Age";
			dataGridView1.Columns[2].HeaderText = "Country";
			dataGridView1.Columns[3].HeaderText = "Playing role";
			dataGridView1.Columns[4].HeaderText = "Batting style";
			dataGridView1.Columns[5].HeaderText = "Bowling style";

			while (dr.Read())
			{
				string[] row = new string[] { dr.GetString(0), dr.GetInt32(1).ToString(), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5) };
				dataGridView1.Rows.Add(row);
			}

		}

		private void label4_Click(object sender, EventArgs e)
		{
			
		}
		

		private void insert_Click(object sender, EventArgs e)
		{
			var con = new SQLiteConnection(cs);
			con.Open();
			

			try
			{
				if (radioButton1.Checked)
				{
					Footballer myFootballer = new Footballer(name_txt.Text, Int32.Parse(age_txt.Text),  club_txt.Text, country_txt.Text, position_txt.Text, Int32.Parse(shirtnum_txt.Text));
					myFootballer.AddData(con);
					footballdata_show();
				}
				else
				{
					Cricketer myCricketer = new Cricketer(name_txt.Text, Int32.Parse(age_txt.Text), club_txt.Text, country_txt.Text, position_txt.Text, shirtnum_txt.Text);
					myCricketer.AddData(con);
					cricketdata_show();
				}
				
			}
			catch (Exception)
			{
				Console.WriteLine("Cannot insert data");
				return;
			}

		}

		private void update_Click(object sender, EventArgs e)
		{
			var con = new SQLiteConnection(cs);
			con.Open();


			try
			{
				if (radioButton1.Checked)
				{
					Footballer myFootballer = new Footballer(name_txt.Text, Int32.Parse(age_txt.Text), club_txt.Text, country_txt.Text, position_txt.Text, Int32.Parse(shirtnum_txt.Text));
					myFootballer.UpdateData(con);
					footballdata_show();
				}
				else
				{
					Cricketer myCricketer = new Cricketer(name_txt.Text, Int32.Parse(age_txt.Text), club_txt.Text, country_txt.Text, position_txt.Text, shirtnum_txt.Text);
					myCricketer.UpdateData(con);
					cricketdata_show();
				}

			}
			catch (Exception)
			{
				Console.WriteLine("Cannot insert data");
				return;
			}

		}

		private void delete_Click(object sender, EventArgs e)
		{
			var con = new SQLiteConnection(cs);
			con.Open();


			try
			{
				if (radioButton1.Checked)
				{
					Footballer myFootballer = new Footballer(name_txt.Text, Int32.Parse(age_txt.Text), club_txt.Text, country_txt.Text, position_txt.Text, Int32.Parse(shirtnum_txt.Text));
					myFootballer.DeleteData(con);
					footballdata_show();
				}
				else
				{
					Cricketer myCricketer = new Cricketer(name_txt.Text, Int32.Parse(age_txt.Text), club_txt.Text, country_txt.Text, position_txt.Text, shirtnum_txt.Text);
					myCricketer.DeleteData(con);
					cricketdata_show();
				}

			}
			catch (Exception)
			{
				Console.WriteLine("Cannot insert data");
				return;
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			
			int index = e.RowIndex;
			DataGridViewRow selectedRow = dataGridView1.Rows[index];
			name_txt.Text = selectedRow.Cells[0].Value.ToString();
			age_txt.Text = selectedRow.Cells[1].Value.ToString();
			club_txt.Text = selectedRow.Cells[2].Value.ToString();
			country_txt.Text = selectedRow.Cells[3].Value.ToString();
			position_txt.Text = selectedRow.Cells[4].Value.ToString();
			shirtnum_txt.Text = selectedRow.Cells[5].Value.ToString();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				footballdata_show();
			}
			else {
				cricketdata_show();
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				label4.Text = "Club:";
				label5.Text = "Country:";
				label6.Text = "Position:";
				label7.Text = "Shirt number:";
				footballdata_show();
				label1.Text = "Footballers Database";
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				label4.Text = "Country:";
				label5.Text = "Playing role:";
				label6.Text = "Batting style:";
				label7.Text = "Bowling style:";
				cricketdata_show();
				label1.Text = "Cricketers Database";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			name_txt.Text = "";
			age_txt.Text = "";
			club_txt.Text = "";
			country_txt.Text = "";
			position_txt.Text = "";
			shirtnum_txt.Text = "";
		}
	}
}
