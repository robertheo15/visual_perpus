using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prymart
{
    public partial class ListBrgEdit : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
        public ListBrgEdit()
        {
            InitializeComponent();
        }

        private void ListBrgEdit_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@ID", comboBox2.SelectedItem);
            command.CommandText = "SELECT * FROM `barang` WHERE id = @ID ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox5.Text = reader.GetInt32(1).ToString();
                textBox2.Text = reader.GetString(2);
                textBox3.Text = reader.GetInt32(3).ToString();
                textBox4.Text = reader.GetInt32(4).ToString();
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "UPDATE `barang` SET Kode_Barang = @kode , Nama_Barang = @nama , Harga_Jual = @harga , Stock = @stock WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", comboBox2.SelectedItem);
            command.Parameters.AddWithValue("@kode", textBox5.Text);
            command.Parameters.AddWithValue("@nama", textBox2.Text);
            command.Parameters.AddWithValue("@harga", textBox3.Text);
            command.Parameters.AddWithValue("@stock", textBox4.Text);

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("record added");
            else
                MessageBox.Show("record not added");
            con.Close();
        }
    }
}
