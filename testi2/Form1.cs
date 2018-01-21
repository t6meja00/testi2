using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace testi2
{
    public partial class Form1 : Form
    {
        Weather getWeatherInfo = new Weather();
        MoonPhase moon = new MoonPhase();

        private int hours = DateTime.Now.Hour;
        private int minutes = DateTime.Now.Minute;
        static double timeToSunsetHours = 0;
        static double timeToSunset = 0;
        static double timeToSunriseHours = 0;
        static double timeToSunrise = 0;
        

        List<string> colors = new List<string> { "#48A6E6", "#3d86c6", "#316eaf", "#295b9b", "#214589", "#1f3c82", "#1f3182", "#17226b", "#101851", "#080d33" };


        public Form1()
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            labelClock.Text = hours.ToString() + " : " + minutes.ToString();
            labelLatestHumidity.Text = getWeatherInfo.GetHumidity() + " %";
            labelLatestTemperature.Text = getWeatherInfo.GetTemperature() + " C";

            Console.WriteLine((getWeatherInfo.GetSunset() - DateTime.Now.TimeOfDay).Minute);

            timeToSunset = getWeatherInfo.GetSunset().Subtract(DateTime.Now).TotalMinutes;
            timeToSunrise = getWeatherInfo.GetSunrise().Subtract(DateTime.Now).TotalMinutes;

            UpdateBackgroundImage();
            pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Console.WriteLine(moon.MoonAge(DateTime.Today));
            UpdateMoon(moon.MoonAge(DateTime.Today));
            CheckWeatherChanges();
            UpdateDayLength();

            FillData("select * from weather");

            if (timeToSunset < 30 && timeToSunset > 0)
            {
                BackColorForSunset();
            }
            else if (timeToSunrise < 30 && timeToSunrise > 0)
            {
                BackColorForSunrise();
            }
            else if (getWeatherInfo.IsNight())
            {
                tabPageMain.BackColor = System.Drawing.ColorTranslator.FromHtml(colors[9]);
            }
            else
            {
                tabPageMain.BackColor = System.Drawing.ColorTranslator.FromHtml(colors[0]);
            }

            timerUpdateMainview.Start();
            timerColorAnimationForSunrise.Start();
            timerColorAnimationForSunset.Start();
        }

        //Info page data
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

        //Admin page buttons

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Database.Execute("truncate table weather");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Database.Execute("DELETE from weather where temperature < -20 OR temperature > 80");
                Database.Execute("DELETE from weather where humidity < 20 OR humidity > 80");
            }
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            Database.Execute("DELETE FROM weather WHERE time LIKE '%" + selectedDate + "%';");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                FillData("select * from weather");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.ResumeLayout();
        }

        private void tableLayoutPanelMainView_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine("double clicked");
            Thread threadFullScreen = new Thread(new ThreadStart(OpenFullScreenView));
            threadFullScreen.Start();
        }

        private void OpenFullScreenView()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => CreateAndShowForm()));
                return;
            }
            CreateAndShowForm();

        }

        private void CreateAndShowForm()
        {
            var frm = new MainViewFullScreen();
            frm.Show();
        }
        //Side buttons
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

        //Search
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



        //Down buttons
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
        
    }
}
