using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi2
{
    class Weather
    {
        DateTime date = DateTime.Today;
        DateTime sunrise = DateTime.Now;
        DateTime sunset = DateTime.Now;
        bool isSunrise = false;
        bool isSunset = false;

        public Weather()
        {
            
        }

        public bool IsNight()
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

        public DateTime GetSunrise()
        {
            date = DateTime.Today;
            SunTimes.Instance.CalculateSunRiseSetTimes(new SunTimes.LatitudeCoords
                                                      (65, 0, 44, SunTimes.LatitudeCoords.Direction.North),
                                                       new SunTimes.LongitudeCoords
                                                      (25, 28, 5, SunTimes.LongitudeCoords.Direction.East),
                                                       date, ref sunrise, ref sunset,
                                                       ref isSunrise, ref isSunset);

            return sunrise;
        }

        public DateTime GetSunset()
        {
            date = DateTime.Today;
            SunTimes.Instance.CalculateSunRiseSetTimes(new SunTimes.LatitudeCoords
                                                      (65, 0, 0, SunTimes.LatitudeCoords.Direction.North),
                                                       new SunTimes.LongitudeCoords
                                                      (25, 30, 0, SunTimes.LongitudeCoords.Direction.East),
                                                       date, ref sunrise, ref sunset,
                                                       ref isSunrise, ref isSunset);

            return sunset;
        }


        public string GetLight()
        {
            return Database.GetOneCell("SELECT light FROM weather WHERE time = (SELECT MAX(time) FROM weather);");
        }

        public string GetTemperature()
        {
            return Database.GetOneCell("SELECT temperature FROM weather WHERE time = (SELECT MAX(time) FROM weather);");
        }

        public string GetHumidity()
        {
            return Database.GetOneCell("SELECT humidity FROM weather WHERE time = (SELECT MAX(time) FROM weather);");
        }
    }
}
