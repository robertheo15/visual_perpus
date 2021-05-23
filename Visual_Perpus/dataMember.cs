using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Visual_Perpus
{
    public partial class Datamember : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Datamember()
        {
            InitializeComponent();
            updateView();
        }

        private void BtnAddDataMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addmember registerform = new Addmember();
            registerform.Show();
        }

        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `users` ";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DataGridMember.Rows.Add(reader.GetString(3), reader.GetString(2), reader.GetString(5), reader.GetString(6));
            }
            con.Close();
        }

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@search", TextBoxSearch.Text);
            command.CommandText = "Select * FROM `users` WHERE  nim = @search";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                DataGridMember.Rows.Clear();
                DataGridMember.Columns.Clear();
                DataGridMember.Refresh();
                DataGridMember.Columns.Add("Col1", "Username");
                DataGridMember.Columns.Add("Col2", "NIM");
                DataGridMember.Columns.Add("Col3", "FirstName");
                DataGridMember.Columns.Add("Col4", "LastName");
                DataGridMember.Columns.Add("Col4", "Register Date");
                DataGridMember.Rows.Add(reader.GetString(3), reader.GetString(2),  reader.GetString(5), reader.GetString(6), reader.GetString(7));

            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@nim_user", TextBoxSearch.Text);
            command.CommandText = "Select * FROM `users` WHERE nim  = @nim_user ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MySqlConnection con1 = new MySqlConnection(connStr);
                con1.Open();
                MySqlCommand command1 = con1.CreateCommand();
                command1.Parameters.AddWithValue("@nim_user",TextBoxSearch.Text);
                command1.CommandText = "DELETE FROM `users` WHERE nim  = @nim_user ";
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
