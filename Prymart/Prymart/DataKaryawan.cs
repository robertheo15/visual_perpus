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
    public partial class DataKaryawan : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public DataKaryawan()
        {
            InitializeComponent();
        }       
        private void DataKaryawan_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            TambahDataKaryawan tbh = new TambahDataKaryawan();
            tbh.ShowDialog();
        }

      
        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `karyawan`";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Columns.Clear();
            bunifuCustomDataGrid1.Columns.Add("namaCol", "Nama Lengkap");
            bunifuCustomDataGrid1.Columns.Add("tempatlahirCol", "Tempat Lahir");
            bunifuCustomDataGrid1.Columns.Add("tanggallahirCol", "Tanggal lahir");
            bunifuCustomDataGrid1.Columns.Add("alamatCol", "Alamat");
            bunifuCustomDataGrid1.Columns.Add("emailCol", "Email");
            bunifuCustomDataGrid1.Columns.Add("nohpCol", "No HP");
            bunifuCustomDataGrid1.Columns.Add("jabatanCol", "Jabatan");
            bunifuCustomDataGrid1.Columns.Add("kotaCol", "KOTA");
            bunifuCustomDataGrid1.Columns.Add("kodeposCol", "KODE POS");
            bunifuCustomDataGrid1.Columns.Add("negaraCol", "Negara");
            while (reader.Read())
            {
                bunifuCustomDataGrid1.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetDateTime(3).ToString("yyyy-MM-dd"),reader.GetString(4), reader.GetString(7), reader.GetInt32(8), reader.GetString(10), reader.GetString(5), reader.GetInt32(7), reader.GetString(6));
            }            
            con.Close(); 
        }

        private void DataKaryawan_Shown(object sender, EventArgs e)
        {
            updateView();
        }
    }
}
