using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Prymart
{

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        
        Login frm2 = new Login();

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_Click(object sender, EventArgs e)
        {
           
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            
        }
        private void Register_Load(object sender, EventArgs e)
        {
            
            frm2.Show(); 
        }
        private void jMetroTextBox1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
            
        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `user` (`username`,`password`,`status`)VALUES (@usn,@pass,@stat)" , db.GetConnection());
            cmd.Parameters.Add("@usn",MySqlDbType.VarChar).Value = textuser.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textpass.Text;
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = "kasir" ;

            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if (textpass.Text.Equals(textconfpass.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            db.closeConnection();
        }
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textuser.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn", db.GetConnection());

            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = cmd;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean checkTextBoxesValues()
        {
            String uname = textuser.Text;
            String pass = textpass.Text;
            //String stat = textstatus.Text;

            if ( uname.Equals("username") || pass.Equals("password") )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnRegis_MouseEnter(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.White;
            btnRegis.ForeColor = Color.Blue;
        }

        private void btnRegis_MouseLeave(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.CornflowerBlue;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

 
    }
    
}
