using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Visual_Perpus
{
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`id_role`, `nim`, `username`,`password`,`first_name`, `last_name`)VALUES (@idRole, @nim ,@username, @password, @firstName, @lastName)", db.GetConnection());
            cmd.Parameters.Add("@idRole", MySqlDbType.Int32).Value = 2;
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBoxUsername.Text;
            cmd.Parameters.Add("@nim", MySqlDbType.VarChar).Value = textBoxNIM.Text;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = TextBoxFirstName.Text;
            cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = TextBoxLastName.Text;         
            db.OpenConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
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
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            db.CloseConnection();
        }

        public Boolean checkUsername()
        {
            Database db = new Database();
            String username = TextBoxUsername.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @username", db.GetConnection());
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
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
            String username = TextBoxUsername.Text;


            if (username.Equals("username"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }      
    }
}
