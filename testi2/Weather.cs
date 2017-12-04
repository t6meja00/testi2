using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi2
{
    class Weather
    {
        public Weather()
        {
            
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
