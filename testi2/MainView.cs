using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testi2
{
    

    public partial class Form1
    {
        DateTime date = DateTime.Today;
        DateTime sunrise = DateTime.Now;
        DateTime sunset = DateTime.Now;
        bool isSunrise = false;
        bool isSunset = false;
        int i = 0;
        List<string> colors = new List<string> { "#48A6E6", "#3d86c6", "#316eaf", "#295b9b", "#214589", "#1f3c82", "#1f3182", "#17226b", "#101851", "#080d33"  };


        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            
        }

        private void timerUpdateMainview_Tick(object sender, EventArgs e)
        {
            UpdateTempAndHumidity();
            
        }

        private void ColorAnimation()
        {
            timerColorAnimation.Start();
            
        }

        private void timerColorAnimation_Tick(object sender, EventArgs e)
        {
            tabPageMain.BackColor = System.Drawing.ColorTranslator.FromHtml(colors[i]);
            
            if (i == 9)
            {
                i = 0;
                timerColorAnimation.Stop();
            }
            else
            {
                i++;
            }
        }

        private void UpdateClock()
        {
            hours = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;

            if (minutes < 10 || hours < 10)
            {
                if (minutes < 10)
                {
                    labelClock.Text = hours.ToString() + " : 0" + minutes.ToString();
                }
                if (hours < 10)
                {
                    labelClock.Text = "0" + hours.ToString() + " : " + minutes.ToString();
                }
                if (minutes < 10 && hours < 10)
                {
                    labelClock.Text = "0" + hours.ToString() + " : 0" + minutes.ToString();
                }
            }
            else
            {
                labelClock.Text = hours.ToString() + " : " + minutes.ToString();
            }
            
        }

        

        private void UpdateTempAndHumidity()
        {
            labelLatestHumidity.Text = getWeatherInfo.GetHumidity() + " %";
            labelLatestTemperature.Text = getWeatherInfo.GetTemperature() + " C";
        }

        private bool IsNight()
        {
            date = DateTime.Today;
            SunTimes.Instance.CalculateSunRiseSetTimes(new SunTimes.LatitudeCoords
                                                      (65, 0, 0, SunTimes.LatitudeCoords.Direction.North),
                                                       new SunTimes.LongitudeCoords
                                                      (25, 30, 0, SunTimes.LongitudeCoords.Direction.East),
                                                       date, ref sunrise, ref sunset,
                                                       ref isSunrise, ref isSunset);
            Console.WriteLine(sunrise);
            Console.WriteLine(sunset);
            if (sunrise > DateTime.Now || DateTime.Now > sunset)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void timerUpdateBackground_Tick(object sender, EventArgs e)
        {
            UpdateMoon(moon.MoonAge(DateTime.Today));
            UpdateBackgroundImage();
        }

        private void UpdateBackgroundImage()
        {
            Console.WriteLine(IsNight());
            

            if (IsNight())
            {
                pictureBoxWeather.Image = Properties.Resources.sun;

                //#0526ff
                labelClock.ForeColor = System.Drawing.ColorTranslator.FromHtml("#050DFF");
                labelLatestHumidity.ForeColor = System.Drawing.ColorTranslator.FromHtml("#050DFF");
                labelLatestTemperature.ForeColor = System.Drawing.ColorTranslator.FromHtml("#050DFF");
            }
            else
            {
                if (Convert.ToDouble(getWeatherInfo.GetTemperature()) < 0)
                {
                    pictureBoxWeather.Image = Properties.Resources.snow;
                }
                else
                {
                    // #08739e background color
                    pictureBoxWeather.Image = Properties.Resources.sun;





                }
            }
            pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            
        }

        private void UpdateMoon(double moonAge)
        {
            if (moonAge == 0 || moonAge == 29)
            {
                pictureBoxMoon.Image = Properties.Resources.moon0_newmoon;
            }
            else if (moonAge >= 1 && moonAge <= 3)
            {
                pictureBoxMoon.Image = Properties.Resources.moon2;
            }
            else if (moonAge == 4 || moonAge == 5)
            {
                pictureBoxMoon.Image = Properties.Resources.moon3;
            }
            else if (moonAge == 6 || moonAge == 7)
            {
                pictureBoxMoon.Image = Properties.Resources.moon4;
            }
            else if (moonAge == 8 || moonAge == 9)
            {
                pictureBoxMoon.Image = Properties.Resources.moon5;
            }
            else if (moonAge == 10 || moonAge == 11)
            {
                pictureBoxMoon.Image = Properties.Resources.moon6;
            }
            else if (moonAge == 12 || moonAge == 13)
            {
                pictureBoxMoon.Image = Properties.Resources.moon7;
            }
            else if (moonAge == 14 || moonAge == 15)
            {
                pictureBoxMoon.Image = Properties.Resources.moon8_fullmoon;
            }
            else if (moonAge == 16 || moonAge == 17)
            {
                pictureBoxMoon.Image = Properties.Resources.moon9;
            }
            else if (moonAge == 18 || moonAge == 19)
            {
                pictureBoxMoon.Image = Properties.Resources.moon10;
            }
            else if (moonAge == 20)
            {
                pictureBoxMoon.Image = Properties.Resources.moon11;
            }
            else if (moonAge == 21 || moonAge == 22)
            {
                pictureBoxMoon.Image = Properties.Resources.moon12;
            }
            else if (moonAge == 23 || moonAge == 24)
            {
                pictureBoxMoon.Image = Properties.Resources.moon13;
            }
            else if (moonAge == 25 || moonAge == 26)
            {
                pictureBoxMoon.Image = Properties.Resources.moon14;
            }
            else if (moonAge == 27)
            {
                pictureBoxMoon.Image = Properties.Resources.moon15;
            }
            else if (moonAge == 28)
            {
                pictureBoxMoon.Image = Properties.Resources.moon16;
            }
        }
    }
}
