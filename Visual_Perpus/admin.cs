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

        private void AdminLoad(object sender, EventArgs e)
        {

        }

        private void BtnPeminjaman_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            Peminjaman pinjam = new Peminjaman();
            pinjam.TopLevel = false;
            pinjam.Show();
            PanelAdmin.Controls.Add(pinjam);
            pinjam.Dock = DockStyle.Fill;
            pinjam.Show();
        }

        private void BtnPengembalian_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            Pengembalian kembali = new Pengembalian();
            kembali.TopLevel = false;
            kembali.Show();
            PanelAdmin.Controls.Add(kembali);
            kembali.Dock = DockStyle.Fill;
            kembali.Show();
        }

        private void BtnDataBuku_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            Databukuadmin datbuk = new Databukuadmin();
            datbuk.TopLevel = false;
            datbuk.Show();
            PanelAdmin.Controls.Add(datbuk);
            datbuk.Dock = DockStyle.Fill;
            datbuk.Show();
        }

        private void BtnDataMember_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            Datamember datamember = new Datamember();
            datamember.TopLevel = false;
            datamember.Show();
            PanelAdmin.Controls.Add(datamember);
            datamember.Dock = DockStyle.Fill;
            datamember.Show();
        }

        private void BtnDataPeminjaman_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            Datapinjam dataPinjam = new Datapinjam();
            dataPinjam.TopLevel = false;
            dataPinjam.Show();
            PanelAdmin.Controls.Add(dataPinjam);
            dataPinjam.Dock = DockStyle.Fill;
            dataPinjam.Show();
        }

        private void BtnLaporan_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            Report report = new Report();
            report.TopLevel = false;
            report.Show();
            PanelAdmin.Controls.Add(report);
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            
        }
    }
}
