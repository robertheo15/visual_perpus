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
    public partial class Databukuadmin : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Databukuadmin()
        {
            InitializeComponent();
            updateView();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            Addbook tbh = new Addbook();
            tbh.ShowDialog();
        }

        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `books` ";
            MySqlDataReader reader = command.ExecuteReader();
            DataGridBook.Rows.Clear();
            DataGridBook.Columns.Clear();
            DataGridBook.Columns.Add("Col1", "Book ID");
            DataGridBook.Columns.Add("Col2", "Title");
            DataGridBook.Columns.Add("Col3", "Author");
            DataGridBook.Columns.Add("Col4", "Year");
            DataGridBook.Columns.Add("Col5", "Qty");
            DataGridBook.Columns.Add("Col6", "Type");
            DataGridBook.Columns.Add("Col7", "Price");
            while (reader.Read())
            {
                DataGridBook.Rows.Add(reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
            }
            con.Close();
        }

        private void DataGridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         // delete

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@judul_buku", bunifuMaterialTextbox1.Text);
            command.CommandText = "Select * FROM `books` WHERE id_book  = @judul_buku ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MySqlConnection con1 = new MySqlConnection(connStr);
                con1.Open();
                MySqlCommand command1 = con1.CreateCommand();
                command1.Parameters.AddWithValue("@judul_buku", bunifuMaterialTextbox1.Text);
                command1.CommandText = "DELETE FROM `books` WHERE id_book  = @judul_buku ";
                MySqlDataReader reader1 = command1.ExecuteReader();
                MessageBox.Show("Data telah dihapus");
                con1.Close();
            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }
    }
}
