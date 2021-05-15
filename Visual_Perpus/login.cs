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
    public partial class Login : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@user", TextBoxUsername.Text);
            command.Parameters.AddWithValue("@pass", TextBoxPassword.Text);
            command.CommandText = "SELECT * FROM users where username  = @user AND password = @pass ";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(1) == "1")
                {
                    Admin adm = new Admin();
                    adm.Show();
                    this.Hide();
                }
            }
            con.Close();       
        }

        private void TextBoxPassword_OnValueChanged(object sender, EventArgs e)
        {
            TextBoxPassword.isPassword = true;
        }
    }
}
