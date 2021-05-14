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
    public partial class DistributorTambah : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";

        public DistributorTambah()
        {
            InitializeComponent();
        }
        private void updateview()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM distributor ";
            MySqlDataReader reader = command.ExecuteReader();

            con.Close();
        }
        private void ClearData()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@namapt", textBox1.Text);
            command.Parameters.AddWithValue("@alamat", textBox3.Text);
            command.Parameters.AddWithValue("@kontak", textBox4.Text);
            command.Parameters.AddWithValue("@nokontak", textBox5.Text);

            command.CommandText = "INSERT INTO distributor (Nama_PT,Alamat,Contact_Person,No_Person) Values (@namapt,@alamat,@kontak,@nokontak) ";
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
