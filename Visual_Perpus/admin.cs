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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            peminjaman pinjam = new peminjaman();
            pinjam.TopLevel = false;
            pinjam.Show();
            panel2.Controls.Add(pinjam);
            pinjam.Dock = DockStyle.Fill;
            pinjam.Show();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pengembalian kembali = new pengembalian();
            kembali.TopLevel = false;
            kembali.Show();
            panel2.Controls.Add(kembali);
            kembali.Dock = DockStyle.Fill;
            kembali.Show();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            dataBukuAdmin datbuk = new dataBukuAdmin();
            datbuk.TopLevel = false;
            datbuk.Show();
            panel2.Controls.Add(datbuk);
            datbuk.Dock = DockStyle.Fill;
            datbuk.Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            dataMember datamember = new dataMember();
            datamember.TopLevel = false;
            datamember.Show();
            panel2.Controls.Add(datamember);
            datamember.Dock = DockStyle.Fill;
            datamember.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            dataPinjam dataPinjam = new dataPinjam();
            dataPinjam.TopLevel = false;
            dataPinjam.Show();
            panel2.Controls.Add(dataPinjam);
            dataPinjam.Dock = DockStyle.Fill;
            dataPinjam.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            report report = new report();
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
