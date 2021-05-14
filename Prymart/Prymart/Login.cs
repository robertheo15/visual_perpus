using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Prymart
{
    public partial class Login : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public Login()
        {
            InitializeComponent();
        }

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@user", textuser.Text);
            command.Parameters.AddWithValue("@pass", textpass.Text);
            command.CommandText = "SELECT * FROM user where username  = @user AND password = @pass ";
            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                if (reader.GetString(3)=="kasir")
                {   
                    Kasir2 ks = new Kasir2();
                    ks.Show();
                    this.Hide();
                }
                if(reader.GetString(3)== "admin")
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                }
            }

            con.Close();                        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerform = new Register();
            registerform.Show();
        }

        private void textpass_OnValueChanged(object sender, EventArgs e)
        {
            textpass.isPassword = true;
        }
    }
}
