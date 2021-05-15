using MySql.Data.MySqlClient;
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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `books` (`id_category`, `id_location`,`title_book`,`author_name`, `year_book`, `quantity`, `book_type`, `book_price`)VALUES (@category, @location, @title, @author, @year, @qty, @type, @price)", db.GetConnection());
            cmd.Parameters.Add("@category", MySqlDbType.VarChar).Value = TextBoxCategory.Text;
            cmd.Parameters.Add("@location", MySqlDbType.Int32).Value = TextBoxLocation.Text;
            cmd.Parameters.Add("@title", MySqlDbType.VarChar).Value = TextBoxTitle.Text;
            cmd.Parameters.Add("@author", MySqlDbType.VarChar).Value = TextBoxAuthor.Text;
            cmd.Parameters.Add("@year", MySqlDbType.DateTime).Value = BookYear.Value;
            cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = TextBoxQty.Text;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = TextBoxPrice.Text;
            cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = TextBoxPrice.Text;
            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Book Has Been Added", "Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR");
            }    
            db.CloseConnection();
        }
    }
}
