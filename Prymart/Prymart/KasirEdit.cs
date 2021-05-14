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
    public partial class KasirEdit : Form
    {
        string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=prymart";

        public KasirEdit()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
