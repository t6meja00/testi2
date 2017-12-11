using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace testi2
{
    public partial class Form1 : Form
    {
        private int hours = DateTime.Now.Hour;
        private int minutes = DateTime.Now.Minute;


        public Form1()
        {
            InitializeComponent();

            labelClock.Text = hours.ToString() + " : " + minutes.ToString();

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
        private void ButtonEmpty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Database.Execute("truncate table weather");
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Database.Execute("DELETE from weather where temperature < -20 OR temperature > 80");
            Database.Execute("DELETE from weather where humidity < 0 OR humidity > 80");
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            Database.Execute("DELETE FROM weather WHERE time LIKE '%" +selectedDate+"%';");
        }
    }
}
