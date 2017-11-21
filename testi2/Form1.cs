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

namespace testi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillData("select * from weather");
        }

        private void FillData(string query)
        {
            Database.conn.Close();
            using (MySqlDataAdapter a = new MySqlDataAdapter(
                    query, Database.conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridViewInfo.DataSource = t;
            }
            dataGridViewInfo.Columns[0].HeaderText = "Time";
            dataGridViewInfo.Columns[1].HeaderText = "Temperature";
            dataGridViewInfo.Columns[2].HeaderText = "Humidity";
            dataGridViewInfo.Columns[3].HeaderText = "Light";
        }
    }
}
