using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Visual_Perpus
{
    public partial class Datapinjam : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Datapinjam()
        {
            InitializeComponent();
            updateView();
        }

        private void updateView()
        {
            DateTime localdate = DateTime.Now;
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT order_detail.id_order_detail,users.first_name,users.last_name, books.title_book, order_detail.date_from, order_detail.date_to , order_detail.date_return, order_detail.status FROM users JOIN order_detail ON order_detail.nim = users.nim JOIN books ON order_detail.id_book = books.id_book";
            MySqlDataReader reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                if (reader.GetDateTime(5) < localdate)
                {
                    DataPeminjaman.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToString("yyyy-MM-dd"), reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetInt32(7));
                }
            }                    
            con.Close();
        }
    }
}
