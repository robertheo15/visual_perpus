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
    public partial class OrderBarang : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public OrderBarang()
        {
            InitializeComponent();
        }

        private void sewaGedungDsbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setoran Harian = new Setoran();
            Harian.Show();
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KeuanganPengeluaranBarang PengeluaranBarang = new KeuanganPengeluaranBarang();
            PengeluaranBarang.Show();
        }

        private void sewaGedungDsbToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KeuanganPengeluaranPenyewaan PengeluaranPenyewaan = new KeuanganPengeluaranPenyewaan();
            PengeluaranPenyewaan.Show();
        }

        private void pendapatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeuanganPendapatan Pendapatan = new KeuanganPendapatan();
            Pendapatan.Show();
        }

        private void liToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBarang Barang = new ListBarang();
            Barang.Show();
        }

        private void purchaseOrderPOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatListOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LihatListOrderBarang ListOrder = new LihatListOrderBarang();
            ListOrder.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login MyLogin = new Login();
            MyLogin.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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
                comboBox1.Items.Add(reader.GetString(1));
            }
            con.Close();
           
        }

        private void updateview2()
        {
            int jumtot = 0 , total = 0 ;            

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `order` WHERE status = 'YA' ";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Columns.Clear();
            bunifuCustomDataGrid1.Columns.Add("tanggal", "date");
            bunifuCustomDataGrid1.Columns.Add("namapt", "NAMA DISTRIBUTOR");
            bunifuCustomDataGrid1.Columns.Add("nama", "NAMA BARANG");
            bunifuCustomDataGrid1.Columns.Add("harga", "HARGA BARANG");
            bunifuCustomDataGrid1.Columns.Add("jumlah", "JUMLAH");
            bunifuCustomDataGrid1.Columns.Add("total", "TOTAL");
            while (reader.Read())
            {
                jumtot = jumtot + reader.GetInt32(4);
                total = total + reader.GetInt32(5);
                bunifuCustomDataGrid1.Rows.Add( reader.GetDateTime(6).ToString("yyyy-MM-dd"),reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5));
            }
            label7.Text = jumtot.ToString();
            label10.Text = total.ToString();
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderBarang_Load(object sender, EventArgs e)
        {
            updateview();
            updateview2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@namapt", comboBox1.SelectedItem);
            command.CommandText = "SELECT * FROM `distributor` WHERE Nama_PT = @namapt ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox8.Text = reader.GetString(3);
            }

        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@namapt", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@namabarang", textBox9.Text);
            command.Parameters.AddWithValue("@jumlah", textBox41.Text);
            command.Parameters.AddWithValue("@harga", textBox1.Text);
            command.Parameters.AddWithValue("@total", textBox43.Text);
            command.Parameters.AddWithValue("@tanggal", dateTimePicker1.Text);

            command.CommandText = "INSERT INTO `order` (nama_distributor,nama_barang,jumlah,harga_barang,total,tanggal,status) Values (@namapt,@namabarang,@jumlah,@harga,@total,@tanggal,'YA') ";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Record was added ! ");
            else
                MessageBox.Show("Record was not added ! ");
            con.Close();
            updateview2();                    
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int jumlah ;
            jumlah = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox41.Text);
            textBox43.Text = jumlah.ToString();
        }
    }
    }
