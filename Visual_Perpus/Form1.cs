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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            peminjaman pinjam = new peminjaman();
            pinjam.TopLevel = false;
            pinjam.Show();
            panel2.Controls.Add(pinjam);
            pinjam.Dock = DockStyle.Fill;
            pinjam.Show();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

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
            dataBukuMember datBuk = new dataBukuMember();
            datBuk.TopLevel = false;
            datBuk.Show();
            panel2.Controls.Add(datBuk);
            datBuk.Dock = DockStyle.Fill;
            datBuk.Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            login login = new login();
            login.TopLevel = false;
            login.Show();
            panel2.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.Show();

        }
    }
}
