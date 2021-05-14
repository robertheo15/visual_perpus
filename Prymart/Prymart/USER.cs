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
    public partial class USER : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart;Convert Zero Datetime=True";
        public USER()
        {
            InitializeComponent();
        }
        private void updateView()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `user` ";
            MySqlDataReader reader = command.ExecuteReader();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Columns.Clear();
            bunifuCustomDataGrid1.Columns.Add("userCol", "USERNAME");
            bunifuCustomDataGrid1.Columns.Add("passCol", "PASSWORD");
            while (reader.Read())
            {
                bunifuCustomDataGrid1.Rows.Add( reader.GetString(1),  reader.GetString(2));
            }
            con.Close();
        }

        private void USER_Shown(object sender, EventArgs e)
        {
            updateView();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
        }
    }
}
