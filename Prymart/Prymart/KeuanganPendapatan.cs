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
    public partial class KeuanganPendapatan : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";

        public KeuanganPendapatan()
        {
            InitializeComponent();
        }       

        

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            int total = 0;
            MySqlConnection con1 = new MySqlConnection(connectionString);
            con1.Open();
            MySqlCommand command1 = con1.CreateCommand();
            command1.Parameters.AddWithValue("@tanggalawal", dateTimePicker1.Text);
            command1.Parameters.AddWithValue("@tanggalakhir", dateTimePicker2.Text);
            command1.CommandText = "SELECT * FROM `order` WHERE status = 'No' AND @tanggalawal<=tanggal AND @tanggalakhir>=tanggal";
            MySqlDataReader reader = command1.ExecuteReader();

            while (reader.Read())
            {
                total = total - reader.GetInt32(5);
                bunifuCustomDataGrid1.Rows.Add(reader.GetDateTime(6).ToString("yyyy-MM-dd"), "PENGELUARAN BARANG", reader.GetInt32(5));

            }
            con1.Close();

            MySqlConnection con2 = new MySqlConnection(connectionString);
            con2.Open();
            MySqlCommand command2 = con2.CreateCommand();
            command2.Parameters.AddWithValue("@tanggalawal1", dateTimePicker1.Text);
            command2.Parameters.AddWithValue("@tanggalakhir1", dateTimePicker2.Text);
            command2.CommandText = "SELECT * FROM `biayabulanan` WHERE @tanggalawal1<=tanggal AND @tanggalakhir1>=tanggal  ";
            MySqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                total = total - reader2.GetInt32(3);
                bunifuCustomDataGrid1.Rows.Add(reader2.GetDateTime(1).ToString("yyyy-MM-dd"), reader2.GetString(2), reader2.GetInt32(3));
            }
            con2.Close();

            MySqlConnection con3 = new MySqlConnection(connectionString);
            con3.Open();
            MySqlCommand command3 = con3.CreateCommand();
            command3.Parameters.AddWithValue("@tanggalawal2", dateTimePicker1.Text);
            command3.Parameters.AddWithValue("@tanggalakhir2", dateTimePicker2.Text);
            command3.CommandText = "SELECT * FROM `kasir` WHERE @tanggalawal2<=tanggal AND @tanggalakhir2>=tanggal  ";
            MySqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                total = total + reader3.GetInt32(1);
                bunifuCustomDataGrid1.Rows.Add(reader3.GetDateTime(2).ToString("yyyy-MM-dd"), "kasir", reader3.GetInt32(1));
            }
            con3.Close();
            label2.Text = total.ToString();
        }
    }
}
