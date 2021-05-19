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
            command.CommandText = "SELECT * FROM `order_detail` ";
            MySqlDataReader reader = command.ExecuteReader();
            DataGridMember.Rows.Clear();
            DataGridMember.Columns.Clear();
            DataGridMember.Columns.Add("Col1", "Username");
            DataGridMember.Columns.Add("Col2", "NIM");
            DataGridMember.Columns.Add("Col3", "FirstName");
            DataGridMember.Columns.Add("Col4", "LastName");
            while (reader.Read())
            {
                DataGridMember.Rows.Add(reader.GetString(3), reader.GetString(2), reader.GetString(5), reader.GetString(6));
            }
            con.Close();
        }

    }
}
