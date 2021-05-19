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
                LabelErrorNim.Text = "Data ditemukan";

                while (reader1.Read())
                {
                    LabelNim.Text = reader.GetString(2);
                    LabelName.Text = reader.GetString(5) + ' '+ reader.GetString(5);
                }


                con1.Close();
            }
            else
            {
                LabelErrorNim.Text = "Data tidak ada";
            }

            con.Close();
        }
        private void BtnPinjamBuku_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBoxIdBookPeminjaman.Text))
            {
                LabelErrorBook.Text = "Id Book belum di isi";
            }
            if (!string.IsNullOrEmpty(TxtBoxNimPeminjaman.Text))
            {
                LabelErrorNim.Text = "Nim Belum Di isi";
            }
            if (!String.IsNullOrEmpty(TxtBoxNimPeminjaman.Text) && !String.IsNullOrEmpty(TxtBoxIdBookPeminjaman.Text))
            {
                LabelErrorBook.Text = "Peminjaman berhasil";
                LabelErrorNim.Text = "Peminjaman berhasil";

                DateTime localdate = DateTime.Now;
                Database db = new Database();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `order_detail` (`id_book`, `id_user`,`date_from`, `date_return`,`date_to`,`status`)VALUES (@idBook, @idUser,  @dateFrom ,@dateReturn, @dateTo, @status)", db.GetConnection());
                cmd.Parameters.Add("@idBook", MySqlDbType.Int32).Value = TxtBoxIdBookPeminjaman.Text;
                cmd.Parameters.Add("@idUser", MySqlDbType.Int32).Value = TxtBoxNimPeminjaman.Text;
                cmd.Parameters.Add("@dateFrom", MySqlDbType.Timestamp).Value = localdate;
                cmd.Parameters.Add("@dateReturn", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@dateTo", MySqlDbType.Timestamp).Value = localdate.AddDays(7);
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = '0';

                db.OpenConnection();
                // execute the query
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Your order Has Been Created", "order succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR");
                }


                db.CloseConnection();

            }

        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@idBook", TxtBoxIdBookPeminjaman.Text);
            command.CommandText = "Select * FROM `books` WHERE id_book  = @idBook";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MySqlConnection con1 = new MySqlConnection(connStr);
                con1.Open();
                MySqlCommand command1 = con1.CreateCommand();
                command1.Parameters.AddWithValue("@idBook", TxtBoxIdBookPeminjaman.Text);
                command1.CommandText = "Select * FROM `books` WHERE id_book  = @idBook";
                MySqlDataReader reader1 = command1.ExecuteReader();
                LabelErrorBook.Text = "Data ditemukan";

                while (reader1.Read())
                {
                    LabelIdBook.Text = reader.GetString(0);
                    LabelTitleBook.Text = reader.GetString(3);
                }

                con1.Close();
            }
            else
            {
                LabelErrorBook.Text = "Data tidak ada";
            }

            con.Close();
        }
    }
}
