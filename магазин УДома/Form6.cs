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

namespace магазин_УДома
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source = sellproducts.db; Version =3"))
            {
                conn.Open();
                string comText = "INSERT INTO Users (Login, pass, Role) VALUES (@login, @pass, @role)";
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn;
                command.CommandText = comText;
                command.Parameters.AddWithValue("@login", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox2.Text);
                command.Parameters.AddWithValue("@role", textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox2.Clear();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Пользователь зарегестрирован");
                conn.Open();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
