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
    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public Form2()
        {
            InitializeComponent();
        }       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@nama", comboBox1.SelectedItem);
            command.CommandText = "SELECT * FROM `order` WHERE nama_barang = @nama  ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader.GetString(1);
                textBox2.Text = reader.GetInt32(3).ToString();
                textBox3.Text = reader.GetInt32(4).ToString();
                textBox4.Text = reader.GetInt32(5).ToString();
            }
        }
        private void updateview()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `order` WHERE status = 'YA' ";
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(2) );
            }
            con.Close();

        }
        private void cleardata()
        {
            comboBox1.Text = " ";
            textBox5.Text = "";
            textBox1.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            updateview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = false ;
            int stock;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@kode", textBox5.Text);
            command.CommandText = "SELECT * FROM `barang` WHERE Kode_Barang = @kode  ";
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                status = true;     
            }
            con.Close();
            if (status == true)
            {                                
                MySqlConnection con3 = new MySqlConnection(connectionString);
                con3.Open();
                MySqlCommand command3 = con3.CreateCommand();
                command3.Parameters.AddWithValue("@kode", textBox5.Text);
                command3.CommandText = "SELECT * FROM `barang` WHERE Kode_Barang = @kode  ";
                MySqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    stock = reader3.GetInt32(4);
                    stock = stock + Convert.ToInt32(textBox3.Text);
                    MySqlConnection con2 = new MySqlConnection(connectionString);
                    con2.Open();
                    MySqlCommand command2 = con2.CreateCommand();
                    command2.Parameters.AddWithValue("@kode", textBox5.Text);
                    command2.Parameters.AddWithValue("@stock", stock);
                    command2.Parameters.AddWithValue("@expired", dateTimePicker1.Text);
                    command2.CommandText = "UPDATE `barang` SET  Stock = @stock , Expired_Date = @expired WHERE Kode_Barang = @kode ";
                    if (command2.ExecuteNonQuery() > 0)
                        MessageBox.Show("record added");
                    else
                        MessageBox.Show("record not added");
                    con2.Close();
                    break;
                }
                con3.Close();                                                             
                //ClearData();
            }
            else
            {
                MySqlConnection con5 = new MySqlConnection(connectionString);
                con5.Open();
                MySqlCommand command5 = con5.CreateCommand();
                command5.Parameters.AddWithValue("@kode", textBox5.Text);
                command5.Parameters.AddWithValue("@nama", comboBox1.Text);
                command5.Parameters.AddWithValue("@harga", textBox2.Text);
                command5.Parameters.AddWithValue("@stock", textBox3.Text);
                command5.Parameters.AddWithValue("@tanggal", dateTimePicker1.Text);

                command5.CommandText = "INSERT INTO `barang` (Kode_Barang,Nama_Barang,Harga_Jual,Stock,Expired_Date) Values (@kode,@nama,@harga,@stock,@tanggal) ";
                if (command5.ExecuteNonQuery() > 0)
                    MessageBox.Show("Record was added ! ");
                else
                    MessageBox.Show("Record was not added ! ");
                con5.Close();
            }
            MySqlConnection con4 = new MySqlConnection(connectionString);
            con4.Open();
            MySqlCommand command4 = con4.CreateCommand();
            command4.Parameters.AddWithValue("@status", "No");
            command4.Parameters.AddWithValue("@nama", comboBox1.Text);
            command4.CommandText = "UPDATE `order` SET  status = @status WHERE nama_barang = @nama ";
            if (command4.ExecuteNonQuery() > 0)
                MessageBox.Show("Record was added ! ");
            else
                MessageBox.Show("Record was not added ! ");
            con4.Close();
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
