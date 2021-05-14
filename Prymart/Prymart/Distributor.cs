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
    public partial class Distributor : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";
     
        public Distributor()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Distributor_Load(object sender, EventArgs e)
        {
            updateView();
        }
       private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM distributor ";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid2.Rows.Clear();
            bunifuCustomDataGrid2.Columns.Clear();
            
            bunifuCustomDataGrid2.Columns.Add("idCol", "ID");
            bunifuCustomDataGrid2.Columns.Add("namaptCol", "Nama_PT");
            bunifuCustomDataGrid2.Columns.Add("alamatCol", "Alamat");
            bunifuCustomDataGrid2.Columns.Add("kontakCol", "Contact_Person");
            bunifuCustomDataGrid2.Columns.Add("nokontakCol", "No_Person");
            while (reader.Read())
            {
                
                bunifuCustomDataGrid2.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
            }
            con.Close();
        }                           
        private void button4_Click(object sender, EventArgs e)
        {
            updateView();
            bunifuCustomDataGrid2.Update();
            bunifuCustomDataGrid2.Refresh();
        }
  
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DistributorEdit editdis = new DistributorEdit();
            editdis.ShowDialog();
            updateView();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DistributorTambah create = new DistributorTambah();
            create.ShowDialog();
            updateView();
        }
    }
}

