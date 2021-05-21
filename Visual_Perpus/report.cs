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
    public partial class Report : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Report()
        {
            InitializeComponent();
        }

        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@dateFrom", DateFrom.Text);
            command.Parameters.AddWithValue("@dateTo", DateTo.Text);
            command.CommandText = "SELECT order_detail.id_order_detail,users.first_name,users.last_name, books.title_book, order_detail.date_from, order_detail.date_to , order_detail.date_return, order_detail.status FROM users JOIN order_detail ON order_detail.nim = users.nim JOIN books ON order_detail.id_book = books.id_book WHERE order_detail.date_from >= @dateFrom AND order_detail.date_to<= @dateTo";
            MySqlDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                LabelError.Text = "Data ditemukan";
                while (reader.Read())
                {
                    DataReport.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToString("yyyy-MM-dd"), reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetInt32(7));
                }
            }
            else
            {
                LabelError.Text = "Data tidak di temukan";
            }
            con.Close();
        }

        private void BtnSearchLaporan_Click(object sender, EventArgs e)
        {
            /*MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@dateFrom", DateFrom.Text);
            command.Parameters.AddWithValue("@dateTo", DateTo.Text);
            command.CommandText = "SELECT order_detail.id_order_detail,users.first_name,users.last_name, books.title_book, order_detail.date_from, order_detail.date_to , order_detail.date_return, order_detail.status FROM users JOIN order_detail ON order_detail.nim = users.nim JOIN books ON order_detail.id_book = books.id_book WHERE order_detail.date_from >= @dateFrom AND order_detail.date_to<= @dateTo";
            MySqlDataReader reader = command.ExecuteReader();
            
           
            if (reader.Read())
            {
                LabelError.Text = "Data ditemukan";
                while (reader.Read())
                {
                    DataReport.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToString("yyyy-MM-dd"), reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetInt32(7));
                }
            }
            else
            {
                LabelError.Text = "Data tidak di temukan";
            }
            con.Close();*/
            DataReport.Rows.Clear();
            updateView();
        }
    }
}
