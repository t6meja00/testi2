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

            labelClock.Text = hours.ToString() + " . " + minutes.ToString();
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
        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Database.Execute("truncate table weather");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Database.Execute("DELETE from weather where temperature < -20 OR temperature > 80");
            Database.Execute("DELETE from weather where humidity < 0 OR humidity > 80");
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
        private void SelectedButton_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            Database.Execute("DELETE FROM weather WHERE time LIKE '%" + selectedDate + "%';");
        }
    }
}
//yolo