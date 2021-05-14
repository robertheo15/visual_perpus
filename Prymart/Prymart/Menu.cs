using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prymart
{
    public partial class Menu : Form
    {
       

        public Menu()
        {
            InitializeComponent();
        }        
           
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            firstcontrol ka = new firstcontrol(); 
            ka.BringToFront();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ListBarang list = new ListBarang();
            list.TopLevel = false;
            list.Show();
            panel3.Controls.Add(list);
            list.Dock = DockStyle.Fill;
            list.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            OrderBarang order = new OrderBarang();
            order.TopLevel = false;
            order.Show();
            panel3.Controls.Add(order);
            order.Dock = DockStyle.Fill;
            order.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            LihatListOrderBarang lihatlist = new LihatListOrderBarang();
            lihatlist.TopLevel = false;
            lihatlist.Show();
            panel3.Controls.Add(lihatlist);
            lihatlist.Dock = DockStyle.Fill;
            lihatlist.Show();
        }
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Distributor distri = new Distributor();
            distri.TopLevel = false;
            distri.Show();
            panel3.Controls.Add(distri);
            distri.Dock = DockStyle.Fill;
            distri.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            KeuanganPendapatan kp = new KeuanganPendapatan();
            kp.TopLevel = false;
            kp.Show();
            panel3.Controls.Add(kp);
            kp.Dock = DockStyle.Fill;
            kp.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            KeuanganPengeluaranPenyewaan kpp = new KeuanganPengeluaranPenyewaan();
            kpp.TopLevel = false;
            kpp.Show();
            panel3.Controls.Add(kpp);
            kpp.Dock = DockStyle.Fill;
            kpp.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            KeuanganPengeluaranBarang kp = new KeuanganPengeluaranBarang();
            kp.TopLevel = false;
            kp.Show();
            panel3.Controls.Add(kp);
            kp.Dock = DockStyle.Fill;
            kp.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            DataKaryawan kp = new DataKaryawan();
            kp.TopLevel = false;
            kp.Show();
            panel3.Controls.Add(kp);
            kp.Dock = DockStyle.Fill;
            kp.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            USER kp = new USER();
            kp.TopLevel = false;
            kp.Show();
            panel3.Controls.Add(kp);
            kp.Dock = DockStyle.Fill;
            kp.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
