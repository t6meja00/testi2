using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi2
{
    

    public partial class Form1
    {
        
        private void timerClock_Tick(object sender, EventArgs e)
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

        private void timerUpdateMainview_Tick(object sender, EventArgs e)
        {
            Weather getWeatherInfo = new Weather();
            label1.Text = getWeatherInfo.GetLight();
        }
    }
}
