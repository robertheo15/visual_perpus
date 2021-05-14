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
    public partial class ListBarangEdit : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public ListBarangEdit()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updateview()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM barang ";
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetInt32(1));
            }
            con.Close();
        }
        private void ClearData()
        {
            comboBox1.SelectedItem = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@kode", comboBox1.SelectedItem);
            command.CommandText = "SELECT * FROM `barang` WHERE Kode_Barang = @kode ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);
                dateTimePicker2.Text = reader.GetDateTime(5).ToString("yyyy-MM-dd");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@kode", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@nama", textBox2.Text);
            command.Parameters.AddWithValue("@harga", textBox3.Text);
            command.Parameters.AddWithValue("@stock", textBox4.Text);
            command.Parameters.AddWithValue("@expired", dateTimePicker2.Text);

            command.CommandText = "UPDATE barang SET Nama_Barang = @nama, Harga_Jual = @harga, Stock = @stock , Expired_Date = @expired  WHERE Kode_Barang = @kode";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("record added");
            else
                MessageBox.Show("record not added");
            con.Close();

            ClearData();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wrong Confirmation Password", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM barang WHERE id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item Deleted ");
                ClearData();
            }
        }

        private void ListBarangEdit_Load(object sender, EventArgs e)
        {
            updateview();
        }
    }
}
