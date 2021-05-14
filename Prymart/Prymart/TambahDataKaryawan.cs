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
    public partial class TambahDataKaryawan : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public TambahDataKaryawan()
        {
            InitializeComponent();
        }       

        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            dateTimePicker1.Text = "";        
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@nama", textBox1.Text);
            command.Parameters.AddWithValue("@tempatlahir", textBox2.Text);
            command.Parameters.AddWithValue("@tanggallahir", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@alamat", textBox3.Text);
            command.Parameters.AddWithValue("@email", textBox8.Text);
            command.Parameters.AddWithValue("@nohp", textBox7.Text);
            command.Parameters.AddWithValue("@jabatan", textBox9.Text);
            command.Parameters.AddWithValue("@negara", textBox5.Text);
            command.Parameters.AddWithValue("@kota", textBox4.Text);
            command.Parameters.AddWithValue("@kodepos", textBox6.Text);

            command.CommandText = "INSERT INTO `karyawan` (Nama_Lengkap,Tempat_Lahir,Tanggal_Lahir,Alamat,Kota,Negara,Kode_Pos,Nomor_HP,Email,Jabatan)Values (@nama,@tempatlahir,@tanggallahir,@alamat,@kota,@negara,@kodepos,@nohp,@email,@jabatan) ";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Record was added ! ");
            else
                MessageBox.Show("Record was not added ! ");
            con.Close();
            cleardata();
        }
    }
}
