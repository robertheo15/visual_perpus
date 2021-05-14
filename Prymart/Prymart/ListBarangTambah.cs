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
    public partial class ListBarangTambah : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
        public ListBarangTambah()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
        private void updateview()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM barang ";
            MySqlDataReader reader = command.ExecuteReader();
            
            con.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@kode", textBox5.Text);
            command.Parameters.AddWithValue("@nama", textBox2.Text);
            command.Parameters.AddWithValue("@harga", textBox3.Text);
            command.Parameters.AddWithValue("@stock", textBox4.Text);
            command.Parameters.AddWithValue("@tanggal", dateTimePicker2.Text);

            command.CommandText = "INSERT INTO barang (Kode_Barang,Nama_Barang,Harga_Jual,Stock,Expired_Date) Values (@kode,@nama,@harga,@stock,@tanggal) ";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Record was added ! ");
            else
                MessageBox.Show("Record was not added ! ");
            con.Close();
            updateview();
            ClearData();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
