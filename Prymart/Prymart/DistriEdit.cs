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
    public partial class DistriEdit : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
        public DistriEdit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@ID", comboBox1.SelectedItem);
            command.CommandText = "SELECT * FROM distributor WHERE id = @ID ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);
                textBox5.Text = reader.GetInt32(4).ToString();
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@ID", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@namapt", textBox1.Text);
            command.Parameters.AddWithValue("@alamat", textBox3.Text);
            command.Parameters.AddWithValue("@kontak", textBox4.Text);
            command.Parameters.AddWithValue("@nokontak", textBox5.Text);

            command.CommandText = "UPDATE distributor SET Nama_PT = @namapt, Alamat = @alamat , Contact_Person = @kontak , NO_Person = @nokontak  WHERE id = @ID";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("record added");
            else
                MessageBox.Show("record not added");
            con.Close();
        }
        private void updateview() 
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM distributor ";
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetInt32(0));
             }
            con.Close();
        }

        private void DistriEdit_Load(object sender, EventArgs e)
        {
            updateview();
        }
    }
}
