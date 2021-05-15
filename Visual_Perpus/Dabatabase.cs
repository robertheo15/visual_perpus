using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Visual_Perpus
{
    class Database
    {
        private MySqlConnection conn;
        private string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
        /*    private string server;
            private string database;
            private string uid;
            private string password;
    */
        public Database()
        {
            conn = new MySqlConnection(connStr);

            MessageBox.Show("Sucess!");
        }

        /*    //open connection to database
            public bool OpenConnection()
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Sucess!");
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }

            //Close connection
            public bool CloseConnection()
            {
                try
                {
                    conn.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }*/
        public MySqlConnection GetConnection()
        {
            return conn;
        }

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}