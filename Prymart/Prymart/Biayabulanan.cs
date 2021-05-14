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
    public partial class biayabulanan : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";

        public biayabulanan()
        {
            InitializeComponent();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@tanggal", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@jenis", textBox1.Text);
            command.Parameters.AddWithValue("@total", textBox2.Text);

            command.CommandText = "INSERT INTO `biayabulanan` (tanggal,jenis,total) Values (@tanggal,@jenis,@total) ";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Record was added ! ");
            else
                MessageBox.Show("Record was not added ! ");
            con.Close();
        }
    }
}
