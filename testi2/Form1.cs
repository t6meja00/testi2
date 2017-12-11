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
            dataGridViewInfo.Sort(dataGridViewInfo.Columns[0], ListSortDirection.Descending);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather";
            FillData(query);
        }

        private void TabCheck()
        {
            if (tabControl1.SelectedIndex != 1)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void buttonCurrentTime_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours)).ToString());
            FillData(query);
        }

        private void buttonLastHour_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 1).ToString());
            FillData(query);
        }

        private void button2HoursAgo_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 2).ToString());
            FillData(query);
        }

        private void button3HoursAgo_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 3).ToString());
            FillData(query);
        }

        private void button4HoursAgo_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 4).ToString());
            FillData(query);
        }

        private void button5HoursAgo_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 5).ToString());
            FillData(query);
        }

        private void button6HoursAgo_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 6).ToString());
            FillData(query);
        }

        private void button7HoursAgo_Click(object sender, EventArgs e)
        {
            TabCheck();
            string query = "SELECT * FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = " + ((Convert.ToInt16(hours) - 7).ToString());
            FillData(query);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
                TabCheck();
                string query = "SELECT * FROM weather WHERE DAY(time) = '" + textBoxSearch.Text + "%'; ";
                if (Database.IsEmpty(query))
                {
                    query = "SELECT * FROM weather WHERE temperature LIKE '%" + textBoxSearch.Text + "%'; ";
                    if (Database.IsEmpty(query))
                    {
                        query = "SELECT * FROM weather WHERE humidity LIKE '%" + textBoxSearch.Text + "%'; ";
                        if (Database.IsEmpty(query))
                        {
                            query = "SELECT * FROM weather WHERE light LIKE '%" + textBoxSearch.Text + "%'; ";
                            FillData(query);
                        }
                        else
                        {
                            FillData(query);
                        }
                    }
                    else
                    {
                        FillData(query);
                    }
                }
                else
                {
                    FillData(query);
                }
            }
        
            
        

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            int index = 0;

            double average = Database.ListCalc(index);
            labelAverage.Text = Math.Round(average, 2).ToString() + "°C";
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            int index = 1;

            double max = Database.ListCalc(index);
            labelMax.Text = Math.Round(max, 2).ToString() + "°C";
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            int index = 2;

            double min = Database.ListCalc(index);
            labelMin.Text = Math.Round(min, 2).ToString() + "°C";
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.') && (e.KeyChar != '/') && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}