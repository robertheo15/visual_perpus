using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Perpus
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Peminjaman pinjam = new Peminjaman();
            pinjam.TopLevel = false;
            pinjam.Show();
            panel2.Controls.Add(pinjam);
            pinjam.Dock = DockStyle.Fill;
            pinjam.Show();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Pengembalian kembali = new Pengembalian();
            kembali.TopLevel = false;
            kembali.Show();
            panel2.Controls.Add(kembali);
            kembali.Dock = DockStyle.Fill;
            kembali.Show();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Databukuadmin datbuk = new Databukuadmin();
            datbuk.TopLevel = false;
            datbuk.Show();
            panel2.Controls.Add(datbuk);
            datbuk.Dock = DockStyle.Fill;
            datbuk.Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Datamember datamember = new Datamember();
            datamember.TopLevel = false;
            datamember.Show();
            panel2.Controls.Add(datamember);
            datamember.Dock = DockStyle.Fill;
            datamember.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Datapinjam dataPinjam = new Datapinjam();
            dataPinjam.TopLevel = false;
            dataPinjam.Show();
            panel2.Controls.Add(dataPinjam);
            dataPinjam.Dock = DockStyle.Fill;
            dataPinjam.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Report report = new Report();
            report.TopLevel = false;
            report.Show();
            panel2.Controls.Add(report);
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
