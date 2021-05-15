using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Visual_Perpus
{
    class Database
    {
        private MySqlConnection conn;
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        public Database()
        {
            conn = new MySqlConnection(connStr);
        }

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}