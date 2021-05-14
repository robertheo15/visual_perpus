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
    public partial class UserEdit : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
        public UserEdit()
        {
            InitializeComponent();
        }
        private void updateview()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM user ";
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(1));
            }
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@user", comboBox1.SelectedItem);
            command.CommandText = "SELECT * FROM user WHERE username = @user ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader.GetString(2);
            }

        }
        private void ClearData()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            updateview();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@user", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@pass", textBox1.Text);

            command.CommandText = "UPDATE user SET password = @pass  WHERE username = @user";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("record added");
            else
                MessageBox.Show("record not added");
            con.Close();
            ClearData();
        }

       
        }
    }

