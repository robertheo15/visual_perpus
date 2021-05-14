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
    public partial class Kasir2 : Form
    {
        int nostruk = 0 ;

        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public Kasir2()
        {
            InitializeComponent();
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(sideMenu.Width == 35)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 150;
                animator1.ShowSync(sideMenu);

            }
            else
            {

                sideMenu.Visible = false;
                sideMenu.Width = 35;
                animator1.ShowSync(sideMenu);
            }
        }
        private void cleardata()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            
        }
        private void cleardata2()
        {
            nostruk = 0;
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox5.Text = "";
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Refresh();  

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `kasir`";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nostruk++;
            }
            nostruk = nostruk + 1;

        }
        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `barang`";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid2.Rows.Clear();
            bunifuCustomDataGrid2.Columns.Clear();
            bunifuCustomDataGrid2.Columns.Add("idCol", "ID");
            bunifuCustomDataGrid2.Columns.Add("kodeCol", "Kode_Barang");
            bunifuCustomDataGrid2.Columns.Add("namaCol", "Nama_Barang");
            bunifuCustomDataGrid2.Columns.Add("hargaCol", "Harga_Jual");
            bunifuCustomDataGrid2.Columns.Add("stockCol", "Stock");
            bunifuCustomDataGrid2.Columns.Add("tanggalCol", "Expired_Date");
            while (reader.Read())
            {
                bunifuCustomDataGrid2.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetDateTime(5).ToString("yyyy-MM-dd"));
            }
            con.Close();
        }
        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateView();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@Kode", textBox1.Text);
            command.CommandText = "SELECT * FROM barang WHERE Kode_Barang = @Kode ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader.GetString(2);
                textBox4.Text = reader.GetInt32(3).ToString();
            }
            else
            {
                MessageBox.Show("no");
            }
        }
       

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
                int tmphargasatuan;
                int tmptotalitem,tmptot,stock;

                
                DataTable ss = new DataTable();
                ss.Columns.Add("no");
                ss.Columns.Add("kode");
                ss.Columns.Add("nama");
                ss.Columns.Add("total_item");
                ss.Columns.Add("harga_satuan");
                ss.Columns.Add("total_harga");

           
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@Kode", textBox1.Text);
            command.CommandText = "SELECT * FROM `barang` WHERE Kode_Barang = @Kode ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                stock = reader.GetInt32(4);
                stock = stock - Convert.ToInt32(textBox2.Text);
                if (stock < 0)
                {
                    MessageBox.Show("Stock tidak mencukupi !");
                }
                else
                {                    
                        DataRow row = ss.NewRow();
                        row["no"] = "1";
                        row["kode"] = textBox1.Text;
                        row["nama"] = textBox3.Text;
                        row["total_item"] = textBox2.Text;
                        row["harga_satuan"] = textBox4.Text;
                        tmphargasatuan = Convert.ToInt32(textBox4.Text);
                        tmptotalitem = Convert.ToInt32(textBox2.Text);
                        tmptot = tmphargasatuan * tmptotalitem;
                        row["total_harga"] = tmptot;
                        int total;
                        total = Convert.ToInt32(textBox6.Text) + tmptot;
                        textBox6.Text = total.ToString();

                        ss.Rows.Add(row);
                        foreach (DataRow Drow in ss.Rows)
                        {
                            int num = bunifuCustomDataGrid1.Rows.Add();
                            bunifuCustomDataGrid1.Rows[num].Cells[0].Value = Drow["no"].ToString();
                            bunifuCustomDataGrid1.Rows[num].Cells[1].Value = Drow["kode"].ToString();
                            bunifuCustomDataGrid1.Rows[num].Cells[2].Value = Drow["nama"].ToString();
                            bunifuCustomDataGrid1.Rows[num].Cells[3].Value = Drow["total_item"].ToString();
                            bunifuCustomDataGrid1.Rows[num].Cells[4].Value = Drow["harga_satuan"].ToString();
                            bunifuCustomDataGrid1.Rows[num].Cells[5].Value = Drow["total_harga"].ToString();

                        }
                        MySqlConnection con2 = new MySqlConnection(connectionString);
                        con2.Open();
                        MySqlCommand command2 = con2.CreateCommand();
                        command2.Parameters.AddWithValue("@Kode2", textBox1.Text);
                        command2.Parameters.AddWithValue("@stock", stock);
                        command2.CommandText = "UPDATE barang SET Stock = @stock WHERE Kode_Barang = @Kode2";
                        MySqlDataReader reader2 = command2.ExecuteReader();

                        con2.Close();

                        MySqlConnection con4 = new MySqlConnection(connectionString);
                        con4.Open();
                        MySqlCommand command4 = con4.CreateCommand();
                        command4.Parameters.AddWithValue("@idstruk", nostruk);                       
                        command4.Parameters.AddWithValue("@no", textBox1.Text);
                        command4.Parameters.AddWithValue("@nama", textBox3.Text);
                        command4.Parameters.AddWithValue("@totalitem", textBox2.Text);
                        command4.Parameters.AddWithValue("@totalharga", tmptot); 
                        command4.Parameters.AddWithValue("@hargabrg", textBox4.Text);
                        command4.CommandText = "INSERT INTO `kasirdetail`(`id_struk`, `Nomor_Barang`, `Nama_Barang`, `Total_Item`, `Harga_Satuan`, `Total_Harga`) VALUES (@idstruk,@no,@nama,@totalitem,@hargabrg,@totalharga)";
                        MySqlDataReader reader4 = command4.ExecuteReader();
                        con4.Close();

                        con2.Close();
                    cleardata();
                                     
                }
            }
            else
            {
                MessageBox.Show("no");
            }

            con.Close();
                
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            textBox7.Text = textBox5.Text;
            int kembalian;
            kembalian = Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox6.Text);
            if (kembalian < 0)
            {
                MessageBox.Show("Uang Kurang dari total !");
            }
            else
            {
                textBox8.Text = kembalian.ToString() ; 
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            KasirEdit editkasir = new KasirEdit();
            editkasir.ShowDialog();
        }

        private void Kasir2_Shown(object sender, EventArgs e)
        {
            updateView();
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `kasir`";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nostruk++;
            }
            nostruk = nostruk + 1;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con4 = new MySqlConnection(connectionString);
            con4.Open();
            MySqlCommand command4 = con4.CreateCommand();
            command4.Parameters.AddWithValue("@idstruk", nostruk);
            command4.Parameters.AddWithValue("@total", textBox6.Text);
            command4.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd"));
            command4.CommandText = "INSERT INTO `kasir`(`id_struk`, `totalharga`,tanggal) VALUES (@idstruk,@total,@tanggal)";
            MySqlDataReader reader4 = command4.ExecuteReader();
            con4.Close();
            cleardata2();
        }
    }
}
