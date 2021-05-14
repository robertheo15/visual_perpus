﻿using System;
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
    public partial class LihatListOrderBarang : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
        public LihatListOrderBarang()
        {
            InitializeComponent();
        }

        private void updateview2()
        {
            int jumtot = 0, total = 0;

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `order` WHERE status = 'YA' ";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Columns.Clear();
            bunifuCustomDataGrid1.Columns.Add("tanggal", "TANGGAL");
            bunifuCustomDataGrid1.Columns.Add("namapt", "NAMA DISTRIBUTOR");
            bunifuCustomDataGrid1.Columns.Add("nama", "NAMA BARANG");
            bunifuCustomDataGrid1.Columns.Add("harga", "HARGA BARANG");
            bunifuCustomDataGrid1.Columns.Add("jumlah", "JUMLAH");
            bunifuCustomDataGrid1.Columns.Add("total", "TOTAL");
            while (reader.Read())
            {
                jumtot = jumtot + reader.GetInt32(4);
                total = total + reader.GetInt32(5);
                bunifuCustomDataGrid1.Rows.Add(reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5));
            }
            label3.Text = jumtot.ToString();
            label4.Text = total.ToString();
            con.Close();

        }
        private void updateview()
        {
            int jumtot = 0, total = 0;
            MySqlConnection con1 = new MySqlConnection(connectionString);
            con1.Open();
            MySqlCommand command1 = con1.CreateCommand();
            command1.CommandText = "SELECT * FROM `order` WHERE status = 'No' ";
            MySqlDataReader reader = command1.ExecuteReader();
            bunifuCustomDataGrid2.Rows.Clear();
            bunifuCustomDataGrid2.Columns.Clear();
            bunifuCustomDataGrid2.Columns.Add("tanggal", "TANGGAL");
            bunifuCustomDataGrid2.Columns.Add("namapt", "NAMA DISTRIBUTOR");
            bunifuCustomDataGrid2.Columns.Add("nama", "NAMA BARANG");
            bunifuCustomDataGrid2.Columns.Add("harga", "HARGA BARANG");
            bunifuCustomDataGrid2.Columns.Add("jumlah", "JUMLAH");
            bunifuCustomDataGrid2.Columns.Add("total", "TOTAL");
            while (reader.Read())
            {

                jumtot = jumtot + reader.GetInt32(4);
                total = total + reader.GetInt32(5);
                bunifuCustomDataGrid2.Rows.Add(reader.GetDateTime(6).ToString("yyyy-MM-dd"), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5));
            }
            label5.Text = jumtot.ToString();
            label6.Text = total.ToString();
            con1.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            
        }

        private void LihatListOrderBarang_Load(object sender, EventArgs e)
        {
            updateview();
            updateview2();
        }

        private void LihatListOrderBarang_Shown(object sender, EventArgs e)
        {
            updateview();
            updateview2();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form2 verf = new Form2();
            verf.ShowDialog();
        }
    }
}
