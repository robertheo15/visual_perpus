using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Perpus
{
    public partial class Peminjaman : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Peminjaman()
        {
            InitializeComponent();
        }

        private void peminjaman_Load(object sender, EventArgs e)
        {

        }

        private void LabelError_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchPeminjaman_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@nim", TxtBoxNimPeminjaman.Text);
            command.CommandText = "Select * FROM `users` WHERE nim  = @nim ";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MySqlConnection con1 = new MySqlConnection(connStr);
                con1.Open();
                MySqlCommand command1 = con1.CreateCommand();
                command1.Parameters.AddWithValue("@nim", TxtBoxNimPeminjaman.Text);
                command1.CommandText = "Select * FROM `users` WHERE nim  = @nim";
                MySqlDataReader reader1 = command1.ExecuteReader();
                TxtBoxErrorNim.Text = "Data ditemukan";

                while (reader1.Read())
                { 
                    TextBoxNim.Text = reader.GetString(2);
                    TextBoxName.Text = reader.GetString(5) + ' '+ reader.GetString(5);
                }


                con1.Close();
            }
            else
            {               
                TxtBoxErrorNim.Text = "Data tidak ada";
            }

            con.Close();
        }
        private void BtnPinjamBuku_Click(object sender, EventArgs e)
        {

        }     
    }
}
