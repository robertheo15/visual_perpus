
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Visual_Perpus
{
    public partial class Databukumember : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Databukumember()
        {
            InitializeComponent();
            UpdateBookView();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBookView()
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM `books` ";
            MySqlDataReader reader = command.ExecuteReader();
            /*DataGridBookMember.Rows.Clear();
            DataGridBookMember.Columns.Clear();*/
            /*DataGridBookMember.Columns.Add("Col1", "Book ID");
            DataGridBookMember.Columns.Add("Col2", "Title");
            DataGridBookMember.Columns.Add("Col3", "Author");
            DataGridBookMember.Columns.Add("Col4", "Year");
            DataGridBookMember.Columns.Add("Col5", "Qty");
            DataGridBookMember.Columns.Add("Col6", "Type");
            DataGridBookMember.Columns.Add("Col7", "Price");*/
            while (reader.Read())
            {
                DataGridBookMember.Rows.Add(reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8), reader.GetString(7));
            }
            con.Close();
        }

        private void BtnSearchBook_Click(object sender, System.EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.Parameters.AddWithValue("@search", TextboxIdBook.Text);
            command.CommandText = "Select * FROM `books` WHERE  id_book = @search";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                DataGridBookMember.Rows.Clear();
                DataGridBookMember.Columns.Clear();
                DataGridBookMember.Refresh();
                DataGridBookMember.Columns.Add("Col1", "Book ID");
                DataGridBookMember.Columns.Add("Col2", "Title");
                DataGridBookMember.Columns.Add("Col3", "Author");
                DataGridBookMember.Columns.Add("Col4", "Year");
                DataGridBookMember.Columns.Add("Col5", "Qty");
                DataGridBookMember.Columns.Add("Col6", "Type");
                DataGridBookMember.Columns.Add("Col7", "Price");
                DataGridBookMember.Rows.Add(reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));

            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }
    }
}
