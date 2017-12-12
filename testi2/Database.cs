using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            conn.Close();

            try
            {
                conn.Open();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    return Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return "0";
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
