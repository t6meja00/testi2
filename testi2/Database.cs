using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi2
{
    public static class Database
    {
        private static MySqlDataReader reader = null;
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

        public static void Execute(string query)
        {
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = query;

            if (reader != null)
            {
                reader.Close();
                conn.Close();
            }

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn.Close();
            }

            reader = command.ExecuteReader();

            while (reader.Read())
            {

            }

            conn.Close();
        }

        public static string GetOneCell(string query)
        {
            List<string> cells = new List<string>();
            MySqlDataReader reader = null;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cells.Add(reader.Read().ToString());
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("virhe");
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            Console.WriteLine(cells);
            
            return cells[0];
        }
    }
}
