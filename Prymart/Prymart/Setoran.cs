using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prymart
{
    public partial class Setoran : Form
    {
        public Setoran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Setoran_Load(object sender, EventArgs e)
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

        private void sewaGedungDsbToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void lihatListOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void orderBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
