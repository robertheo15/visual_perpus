using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prymart
{
    class DB
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=prymart");
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return con;
        }
    }
}
