using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prymart
{
    public partial class DistributorEdit : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
        
        public DistributorEdit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@ID", comboBox1.SelectedItem);
            command.CommandText = "SELECT * FROM distributor WHERE id = @ID ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);
                textBox5.Text = reader.GetInt32(4).ToString();
            }
        }

        private void updateview() 
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM distributor ";
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetInt32(0));
             }
            con.Close();
        }

        private void DistriEdit_Load(object sender, EventArgs e)
        {
            updateview();
        }
        private void ClearData()
        {
            comboBox1.SelectedItem = "" ;
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wrong Confirmation Password", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM distributor WHERE id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item Deleted ");
                ClearData();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@ID", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@namapt", textBox1.Text);
            command.Parameters.AddWithValue("@alamat", textBox3.Text);
            command.Parameters.AddWithValue("@kontak", textBox4.Text);
            command.Parameters.AddWithValue("@nokontak", textBox5.Text);

            command.CommandText = "UPDATE distributor SET Nama_PT = @namapt, Alamat = @alamat , Contact_Person = @kontak , NO_Person = @nokontak  WHERE id = @ID";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("record added");
            else
                MessageBox.Show("record not added");
            con.Close();
            ClearData();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
