using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static Visual_Perpus.Database;

namespace Visual_Perpus
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }


        private void textboxUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@user", textboxUsername.Text);
            command.Parameters.AddWithValue("@pass", textBoxPassword.Text);
            command.CommandText = "SELECT * FROM users where username  = @user AND password = @pass ";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(1) == "1")
                {
                    Admin adm = new Admin();
                    adm.Show();
                    Hide();
                }
            }
            conn.Close();
        }
    }
}
