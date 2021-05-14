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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable ss = new DataTable();
            ss.Columns.Add("nobarang");
            ss.Columns.Add("namabarang");
            ss.Columns.Add("total");
            ss.Columns.Add("harga");
            ss.Columns.Add("jumlah");
            ss.Columns.Add("hapus");

            DataRow row = ss.NewRow();
            row["nobarang"] = textBox62.Text;
            row["namabarang"] =
            row["total"] = comboBox2.Text;
            row["harga"] =
            row["jumlah"] =
            row["hapus"] = HapusAksiKasir.UseColumnTextForButtonValue;

            ss.Rows.Add(row);
            foreach (DataRow Drow in ss.Rows)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = Drow["nobarang"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = Drow["namabarang"].ToString();
                dataGridView1.Rows[num].Cells[2].Value = Drow["total"].ToString();
                dataGridView1.Rows[num].Cells[3].Value = Drow["harga"].ToString();
                dataGridView1.Rows[num].Cells[4].Value = Drow["jumlah"].ToString();
                dataGridView1.Rows[num].Cells[5].Value = Drow["hapus"].ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kembalian, operand1, operand2;
            operand1 = Convert.ToInt32(textBox53.Text);
            operand2 = Convert.ToInt32(textBox46.Text);
            kembalian = operand1 - operand2;
            label7.Text = kembalian.ToString();
        }
    }
}
