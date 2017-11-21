using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi2
{
    static class Database
    {
        public static MySqlConnection conn = new MySqlConnection("server = mysli.oamk.fi; database = opisk_t6meja00; user id = t6meja00; password = oT5JPmNamE59RWCj;");

        public static void ExecuteQuery(string query)
        {
            try
            {
                // Open the connection
                conn.Open();
                
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
