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
    public partial class Datamember : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Datamember()
        {
            InitializeComponent();
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
            DataGridMember.Rows.Clear();
            DataGridMember.Columns.Clear();
            DataGridMember.Columns.Add("userCol", "USERNAME");
            DataGridMember.Columns.Add("passCol", "PASSWORD");
            while (reader.Read())
            {
                DataGridMember.Rows.Add(reader.GetString(1), reader.GetString(2));
            }
            con.Close();
        }

        private void USER_Shown(object sender, EventArgs e)
        {
            updateView();

        }

    }
}
