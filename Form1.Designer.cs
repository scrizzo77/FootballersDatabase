
namespace SQLiteTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.name_txt = new System.Windows.Forms.TextBox();
			this.age_txt = new System.Windows.Forms.TextBox();
			this.club_txt = new System.Windows.Forms.TextBox();
			this.country_txt = new System.Windows.Forms.TextBox();
			this.position_txt = new System.Windows.Forms.TextBox();
			this.shirtnum_txt = new System.Windows.Forms.TextBox();
			this.Insert = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Shirt_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(522, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(448, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Footballers database";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(45, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Age: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(45, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Club: ";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(45, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Country: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(45, 298);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "Position: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(45, 351);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "Shirt number: ";
			// 
			// name_txt
			// 
			this.name_txt.Location = new System.Drawing.Point(221, 87);
			this.name_txt.Name = "name_txt";
			this.name_txt.Size = new System.Drawing.Size(238, 26);
			this.name_txt.TabIndex = 7;
			// 
			// age_txt
			// 
			this.age_txt.Location = new System.Drawing.Point(221, 141);
			this.age_txt.Name = "age_txt";
			this.age_txt.Size = new System.Drawing.Size(238, 26);
			this.age_txt.TabIndex = 8;
			// 
			// club_txt
			// 
			this.club_txt.Location = new System.Drawing.Point(221, 194);
			this.club_txt.Name = "club_txt";
			this.club_txt.Size = new System.Drawing.Size(238, 26);
			this.club_txt.TabIndex = 9;
			// 
			// country_txt
			// 
			this.country_txt.Location = new System.Drawing.Point(221, 248);
			this.country_txt.Name = "country_txt";
			this.country_txt.Size = new System.Drawing.Size(238, 26);
			this.country_txt.TabIndex = 10;
			// 
			// position_txt
			// 
			this.position_txt.Location = new System.Drawing.Point(221, 299);
			this.position_txt.Name = "position_txt";
			this.position_txt.Size = new System.Drawing.Size(238, 26);
			this.position_txt.TabIndex = 11;
			// 
			// shirtnum_txt
			// 
			this.shirtnum_txt.Location = new System.Drawing.Point(221, 352);
			this.shirtnum_txt.Name = "shirtnum_txt";
			this.shirtnum_txt.Size = new System.Drawing.Size(238, 26);
			this.shirtnum_txt.TabIndex = 12;
			// 
			// Insert
			// 
			this.Insert.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insert.Location = new System.Drawing.Point(221, 450);
			this.Insert.Name = "Insert";
			this.Insert.Size = new System.Drawing.Size(140, 53);
			this.Insert.TabIndex = 13;
			this.Insert.Text = "Insert";
			this.Insert.UseVisualStyleBackColor = true;
			this.Insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// Update
			// 
			this.Update.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update.Location = new System.Drawing.Point(221, 509);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(140, 53);
			this.Update.TabIndex = 14;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.update_Click);
			// 
			// Delete
			// 
			this.Delete.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Location = new System.Drawing.Point(221, 568);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(140, 53);
			this.Delete.TabIndex = 15;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Age,
            this.Club,
            this.Country,
            this.Position,
            this.Shirt_number});
			this.dataGridView1.Location = new System.Drawing.Point(529, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(967, 645);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.MinimumWidth = 8;
			this.Name.Name = "Name";
			this.Name.Width = 150;
			// 
			// Age
			// 
			this.Age.HeaderText = "Age";
			this.Age.MinimumWidth = 8;
			this.Age.Name = "Age";
			this.Age.Width = 150;
			// 
			// Club
			// 
			this.Club.HeaderText = "Club";
			this.Club.MinimumWidth = 8;
			this.Club.Name = "Club";
			this.Club.Width = 150;
			// 
			// Country
			// 
			this.Country.HeaderText = "Country";
			this.Country.MinimumWidth = 8;
			this.Country.Name = "Country";
			this.Country.Width = 150;
			// 
			// Position
			// 
			this.Position.HeaderText = "Position";
			this.Position.MinimumWidth = 8;
			this.Position.Name = "Position";
			this.Position.Width = 150;
			// 
			// Shirt_number
			// 
			this.Shirt_number.HeaderText = "Shirt_number";
			this.Shirt_number.MinimumWidth = 8;
			this.Shirt_number.Name = "Shirt_number";
			this.Shirt_number.Width = 150;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(1547, 233);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(410, 112);
			this.radioButton1.TabIndex = 17;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Football";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(1547, 422);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(368, 112);
			this.radioButton2.TabIndex = 18;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Cricket";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(221, 627);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 53);
			this.button1.TabIndex = 19;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2029, 877);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.Insert);
			this.Controls.Add(this.shirtnum_txt);
			this.Controls.Add(this.position_txt);
			this.Controls.Add(this.country_txt);
			this.Controls.Add(this.club_txt);
			this.Controls.Add(this.age_txt);
			this.Controls.Add(this.name_txt);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Text = "Sports players form";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox name_txt;
		private System.Windows.Forms.TextBox age_txt;
		private System.Windows.Forms.TextBox club_txt;
		private System.Windows.Forms.TextBox country_txt;
		private System.Windows.Forms.TextBox position_txt;
		private System.Windows.Forms.TextBox shirtnum_txt;
		private System.Windows.Forms.Button Insert;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Club;
		private System.Windows.Forms.DataGridViewTextBoxColumn Country;
		private System.Windows.Forms.DataGridViewTextBoxColumn Position;
		private System.Windows.Forms.DataGridViewTextBoxColumn Shirt_number;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button button1;
	}
}

