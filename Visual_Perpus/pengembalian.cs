using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Visual_Perpus
{
    public partial class Pengembalian : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Pengembalian()
        {
            InitializeComponent();
        }

        private void BtnSearchPengembalian_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@nim", TxtBoxNim.Text);
            command.CommandText = "Select * FROM `users` WHERE nim  = @nim ";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MySqlConnection con1 = new MySqlConnection(connStr);
                con1.Open();
                MySqlCommand command1 = con1.CreateCommand();
                command1.Parameters.AddWithValue("@nim", TxtBoxNim.Text);
                command1.CommandText = "Select * FROM `users` WHERE nim  = @nim";
                MySqlDataReader reader1 = command1.ExecuteReader();
               

                while (reader1.Read())
                {
                    LabelNim.Text = reader.GetString(2);
                    LabelName.Text = reader.GetString(5) + ' ' + reader.GetString(5);
                }
                updateView();

                con1.Close();
            }
            else
            {
                LabelError.Text = "Data tidak ada";
            }

            con.Close();
        }

        private void BtnPengembalian_Click(object sender, EventArgs e)
        {
            
        }

        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@nim", TxtBoxNim.Text);
            command.CommandText = "SELECT order_detail.id_order_detail,users.first_name,users.last_name, books.title_book, order_detail.date_from, order_detail.date_to , order_detail.date_return, order_detail.status FROM users JOIN order_detail ON order_detail.nim = users.nim JOIN books ON order_detail.id_book = books.id_book WHERE users.nim = @nim;";
            MySqlDataReader reader = command.ExecuteReader();
            DataGridMember.Rows.Clear();
           /* DataGridMember.Columns.Clear();
            DataGridMember.Columns.Add("Col1", "Username");
            DataGridMember.Columns.Add("Col2", "NIM");
            DataGridMember.Columns.Add("Col3", "FirstName");
            DataGridMember.Columns.Add("Col4", "LastName");*/
            while (reader.Read())
            {
                
               
                DataGridMember.Rows.Add(reader.GetInt16(0), reader.GetString(1) , reader.GetString(3), reader.GetDateTime(4).ToString("yyyy-MM-dd"), reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetInt16(7));
            }
            con.Close();
        }

    }
}
