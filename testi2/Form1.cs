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
        Weather getWeatherInfo = new Weather();
        MoonPhase moon = new MoonPhase();

        private int hours = DateTime.Now.Hour;
        private int minutes = DateTime.Now.Minute;
        
        public Form1()
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            labelClock.Text = hours.ToString() + " : " + minutes.ToString();
            labelLatestHumidity.Text = getWeatherInfo.GetHumidity() + " %";
            labelLatestTemperature.Text = getWeatherInfo.GetTemperature() + " C";

            UpdateBackgroundImage();
            pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Console.WriteLine(moon.MoonAge(DateTime.Today));
            UpdateMoon(moon.MoonAge(DateTime.Today));

            ColorAnimation();

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

        
    }
}
