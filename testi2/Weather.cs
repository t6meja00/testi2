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
            return Database.GetOneCell("SELECT * FROM weather;");
        }
    }
}
