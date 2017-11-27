using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace testi2
{
    public partial class Form1
    {
        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            Database.Execute("truncate table weather");
        }
    } 
}
