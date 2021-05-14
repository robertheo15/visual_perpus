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
    public partial class ListBarang : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public ListBarang()
        {
            InitializeComponent();
        }
        private void ListBarang_Load(object sender, EventArgs e)
        {
            updateView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }    
        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM barang";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Columns.Clear();
            bunifuCustomDataGrid1.Columns.Add("idCol", "ID");
            bunifuCustomDataGrid1.Columns.Add("kodeCol", "Kode Barang");
            bunifuCustomDataGrid1.Columns.Add("namaCol", "Nama Barang");
            bunifuCustomDataGrid1.Columns.Add("hargaCol", "Harga Jual");
            bunifuCustomDataGrid1.Columns.Add("stockCol", "Stock");
            bunifuCustomDataGrid1.Columns.Add("tanggalCol", "Expired Date");
            while (reader.Read())
            {               
                bunifuCustomDataGrid1.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetDateTime(5).ToString("yyyy-MM-dd"));
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang ", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }        
        private void button4_Click(object sender, EventArgs e)
        {
            updateView();
            bunifuCustomDataGrid1.Update();
            bunifuCustomDataGrid1.Refresh();
        }
        private void ListBarang_Shown(object sender, EventArgs e)
        {
            updateView();

        }     
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ListBarangEdit create = new ListBarangEdit();
            create.ShowDialog();
            updateView();
        }
    }
}


        