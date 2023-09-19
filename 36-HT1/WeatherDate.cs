using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_HT1
{
    internal class WeatherDate
    {
        public (double Temperature, double Humidity, double WindSpeed) Reading { get; set; }

        public WeatherDate(double temperature, double humidity, double windSpeed)
        {
            Reading = (temperature, humidity, windSpeed);
        }
    }
}
