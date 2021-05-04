using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perpus_Visual.models
{
    class Database
    {
        public Database()
        {
            string connStr = "SERVER=localhost;DATABASE=library_visual;USER=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connStr);

        }
    }
       
}
