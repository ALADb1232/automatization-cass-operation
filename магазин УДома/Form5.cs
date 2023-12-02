﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace магазин_УДома
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=sellproducts.db; Version=3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Users";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adap = new SQLiteDataAdapter(command);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь удален");
            SQLiteConnection conn = new SQLiteConnection("Data source=sellproducts.db; Version=3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Users WHERE id=@id";
            command.Parameters.AddWithValue("@id", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            command.ExecuteNonQuery();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=sellproducts.db; Version=3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Users";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adap = new SQLiteDataAdapter(command);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
