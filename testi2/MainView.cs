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
        
        int i = 0;
        double tempHourAgo = 0;
        double tempCurrent = 0;
        double humidityHourAgo = 0;
        double humidityCurrent = 0;

        

        string query = "";

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void timerUpdateMainview_Tick(object sender, EventArgs e)
        {
            UpdateTempAndHumidity();
            CheckWeatherChanges();
        }

        private void CheckWeatherChanges()
        {
            query = "SELECT avg(temperature) FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = '" + (DateTime.Now.Hour - 1).ToString() + "';";

            double.TryParse(Database.GetOneCell(query), out tempHourAgo);
            double.TryParse(getWeatherInfo.GetTemperature(), out tempCurrent);
            
            if (tempCurrent > tempHourAgo)
            {
                pictureBoxTemperatureChange.Image = Properties.Resources.green_arrow;
            }
            else
            {
                pictureBoxTemperatureChange.Image = Properties.Resources.red_arrow;
            }

            query = "SELECT avg(humidity) FROM weather WHERE DATE(time) = '" + DateTime.Today.ToString("yyyy.MM.dd") + "' AND HOUR(time) = '" + (DateTime.Now.Hour - 1).ToString() + "';";

            double.TryParse(Database.GetOneCell(query), out humidityHourAgo);
            double.TryParse(getWeatherInfo.GetHumidity(), out humidityCurrent);
            
            if (humidityCurrent > humidityHourAgo)
            {
                pictureBoxHumidityChange.Image = Properties.Resources.green_arrow;
            }
            else
            {
                pictureBoxHumidityChange.Image = Properties.Resources.red_arrow;
            }

            int.TryParse(getWeatherInfo.GetLight(), out int light);

            
            if (getWeatherInfo.IsNight() == false)
            {
                if (tempCurrent < 0 && humidityCurrent > 50)
                {
                    pictureBoxWeather.Image = Properties.Resources.snowrain;
                }
                else if (tempCurrent > 0 && humidityCurrent > 50)
                {
                    pictureBoxWeather.Image = Properties.Resources.rainy;
                }
                else if (light < 300)
                {
                    pictureBoxWeather.Image = Properties.Resources.cloudy;
                }
                else if (light > 300)
                {
                    pictureBoxWeather.Image = Properties.Resources.sunny;
                }
            }
            else
            {
                pictureBoxWeather.Image = Properties.Resources.star;
            }
        }

        private void timerColorAnimationForSunrise_Tick(object sender, EventArgs e)
        {
            timeToSunriseHours = (DateTime.Now).Subtract(getWeatherInfo.GetSunrise()).Hours;
            timeToSunrise = (DateTime.Now).Subtract(getWeatherInfo.GetSunrise()).Minutes;
            BackColorForSunrise();
            
        }

        private void BackColorForSunrise()
        {
            if (timeToSunrise < 30 && timeToSunrise > 0 && timeToSunriseHours < 1)
            {
                if (timeToSunrise > 0 && timeToSunrise <= 3) { i = 0; }
                if (timeToSunrise > 3 && timeToSunrise <= 6) { i = 1; }
                if (timeToSunrise > 6 && timeToSunrise <= 9) { i = 2; }
                if (timeToSunrise > 9 && timeToSunrise <= 12) { i = 3; }
                if (timeToSunrise > 12 && timeToSunrise <= 15) { i = 4; }
                if (timeToSunrise > 15 && timeToSunrise <= 18) { i = 5; }
                if (timeToSunrise > 18 && timeToSunrise <= 21) { i = 6; }
                if (timeToSunrise > 21 && timeToSunrise <= 24) { i = 7; }
                if (timeToSunrise > 24 && timeToSunrise <= 27) { i = 8; }
                if (timeToSunrise > 27 && timeToSunrise <= 30) { i = 9; }
                else {  }
                tabPageMain.BackColor = System.Drawing.ColorTranslator.FromHtml(colors[i]);
            }
        }

        private void timerColorAnimationForSunset_Tick(object sender, EventArgs e)
        {
            timeToSunsetHours = getWeatherInfo.GetSunset().Subtract(DateTime.Now).Hours;
            timeToSunset = getWeatherInfo.GetSunset().Subtract(DateTime.Now).Minutes;
            BackColorForSunset();
            
        }

        private void BackColorForSunset()
        {
            if (timeToSunset < 30 && timeToSunset > 0 && timeToSunsetHours < 1)
            {
                if (timeToSunset > 0 && timeToSunset <= 3) { i = 9; }
                if (timeToSunset > 3 && timeToSunset <= 6) { i = 8; }
                if (timeToSunset > 6 && timeToSunset <= 9) { i = 7; }
                if (timeToSunset > 9 && timeToSunset <= 12) { i = 6; }
                if (timeToSunset > 12 && timeToSunset <= 15) { i = 5; }
                if (timeToSunset > 15 && timeToSunset <= 18) { i = 4; }
                if (timeToSunset > 18 && timeToSunset <= 21) { i = 3; }
                if (timeToSunset > 21 && timeToSunset <= 24) { i = 2; }
                if (timeToSunset > 24 && timeToSunset <= 27) { i = 1; }
                if (timeToSunset > 27 && timeToSunset <= 30) { i = 0; }

                tabPageMain.BackColor = System.Drawing.ColorTranslator.FromHtml(colors[i]);
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
                    labelClock.Text = hours.ToString() + " . 0" + minutes.ToString();
                }
                if (hours < 10)
                {
                    labelClock.Text = "0" + hours.ToString() + " . " + minutes.ToString();
                }
                if (minutes < 10 && hours < 10)
                {
                    labelClock.Text = "0" + hours.ToString() + " . 0" + minutes.ToString();
                }
            }
            else
            {
                labelClock.Text = hours.ToString() + " . " + minutes.ToString();
            }
            
        }

        private void UpdateDayLength()
        {
            // Sunrise
            if (getWeatherInfo.GetSunrise().Minute < 10)
            {
                labelSunrise.Text = "Sunrise: " + getWeatherInfo.GetSunrise().Hour + ".0" + getWeatherInfo.GetSunrise().Minute;
            }
            if (getWeatherInfo.GetSunrise().Hour < 10)
            {
                labelSunrise.Text = "Sunrise: " + getWeatherInfo.GetSunrise().Hour + "0." + getWeatherInfo.GetSunrise().Minute;
            }
            if (getWeatherInfo.GetSunrise().Hour >= 10 && getWeatherInfo.GetSunrise().Minute >= 10)
            {
                labelSunrise.Text = "Sunrise: " + getWeatherInfo.GetSunrise().Hour + "." + getWeatherInfo.GetSunrise().Minute;
            }
            Console.WriteLine("SUNRISE MIN " + getWeatherInfo.GetSunrise().Minute);
            Console.WriteLine("SUNRISE HOUR " + getWeatherInfo.GetSunrise().Hour);
            Console.WriteLine("SUNRISE MIN AND HOUR" + getWeatherInfo.GetSunrise().Minute + " " + getWeatherInfo.GetSunrise().Hour);
            // Sunset
            if (getWeatherInfo.GetSunset().Minute < 10)
            {
                labelSunset.Text = "Sunset: " + getWeatherInfo.GetSunset().Hour + ".0" + getWeatherInfo.GetSunset().Minute;
            }
            if (getWeatherInfo.GetSunset().Hour < 10)
            {
                labelSunset.Text = "Sunset: " + getWeatherInfo.GetSunset().Hour + "0." + getWeatherInfo.GetSunset().Minute;
            }
            if (getWeatherInfo.GetSunset().Hour >= 10 && getWeatherInfo.GetSunset().Minute >= 10)
            {
                labelSunset.Text = "Sunset: " + getWeatherInfo.GetSunset().Hour + "." + getWeatherInfo.GetSunset().Minute;
            }

            labelDayLength.Text = "Day length: " + (getWeatherInfo.GetSunset() - getWeatherInfo.GetSunrise()).Hours.ToString() + " h " + (getWeatherInfo.GetSunset() - getWeatherInfo.GetSunrise()).Minutes.ToString() + " min";

        }

        private void UpdateTempAndHumidity()
        {
            labelLatestHumidity.Text = getWeatherInfo.GetHumidity() + " %";
            labelLatestTemperature.Text = getWeatherInfo.GetTemperature() + " C";
        }

        
        private void timerUpdateBackground_Tick(object sender, EventArgs e)
        {
            UpdateMoon(moon.MoonAge(DateTime.Today));
            UpdateBackgroundImage();
        }

        private void UpdateBackgroundImage()
        {
            if (getWeatherInfo.GetSunset().Hour - DateTime.Now.Hour < 1 && getWeatherInfo.GetSunset().Minute - DateTime.Now.Minute < 30)
            {
                timerColorAnimationForSunset.Start();
            }
            if (getWeatherInfo.GetSunrise().Hour - DateTime.Now.Hour < 1 && getWeatherInfo.GetSunrise().Minute - DateTime.Now.Minute < 30)
            {
                timerColorAnimationForSunrise.Start();
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
