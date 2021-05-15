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
            DataGridBook.Columns.Add("Col1", "Title");
            DataGridBook.Columns.Add("Col2", "Author");
            DataGridBook.Columns.Add("col3", "Year");
            DataGridBook.Columns.Add("Col4", "Qty");
            DataGridBook.Columns.Add("Col5", "Type");
            DataGridBook.Columns.Add("Col6", "Price");
            while (reader.Read())
            {
                DataGridBook.Rows.Add(reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
            }
            con.Close();
        }
    }
}
