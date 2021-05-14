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
    public partial class KeuanganPengeluaranBarang : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public KeuanganPengeluaranBarang()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int total = 0; 
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@tanggalawal", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@tanggalakhir", dateTimePicker2.Text);
            command.CommandText = "SELECT * FROM `order` WHERE status = 'No' AND @tanggalawal>=tanggal AND @tanggalakhir<=tanggal  ";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Columns.Clear();
            bunifuCustomDataGrid1.Columns.Add("tanggal", "TANGGAL");
            bunifuCustomDataGrid1.Columns.Add("nama_barang", "NAMA BARANG");
            bunifuCustomDataGrid1.Columns.Add("jumlah", "JUMLAH");
            bunifuCustomDataGrid1.Columns.Add("harga_barang", "HARGA BARANG");
            bunifuCustomDataGrid1.Columns.Add("total", "TOTAL");
            while (reader.Read())
            {
                total = total + reader.GetInt32(5);
                bunifuCustomDataGrid1.Rows.Add(reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetString(2), reader.GetInt32(4), reader.GetInt32(3), reader.GetInt32(5));
            }
            label2.Text = total.ToString();
             con.Close();

        }
    }
}
