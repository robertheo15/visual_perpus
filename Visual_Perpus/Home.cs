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
    public partial class Home : Form
    {
        private Database db;
        public Home()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Peminjaman pinjam = new Peminjaman
            {
                TopLevel = false
            };
            pinjam.Show();
            panelView.Controls.Add(pinjam);
            pinjam.Dock = DockStyle.Fill;
            pinjam.Show();
        }

        private void libraryLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Pengembalian kembali = new Pengembalian
            {
                TopLevel = false
            };
            kembali.Show();
            panelView.Controls.Add(kembali);
            kembali.Dock = DockStyle.Fill;
            kembali.Show();
        }

        private void btnDataBuku_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Databukumember datBuk = new Databukumember
            {
                TopLevel = false
            };
            datBuk.Show();
            panelView.Controls.Add(datBuk);
            datBuk.Dock = DockStyle.Fill;
            datBuk.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Login login = new Login
            {
                TopLevel = false
            };
            login.Show();
            panelView.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.Show();

        }
    }
}
