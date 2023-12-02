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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source = sellproducts.db; Version =3"))
            {
                conn.Open();
                string comText = "INSERT INTO sellproducts (Name, description, Date, ) VALUES (@name, @price, @value)";
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn;
                command.CommandText = comText;
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.Parameters.AddWithValue("@price", textBox2.Text);
                command.Parameters.AddWithValue("@value", textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Товар добавлен");
                conn.Open();
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
