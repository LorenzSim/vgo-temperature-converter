using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class FahrenheitTemperatureScale : ITemperatureScale
    {
        public string Name => "Fahrenheit";

        public double ConvertFromKelvin(double temperature)
        {
            return (temperature - 273.15) * 9 / 5 + 32;
        }

        public double ConvertToKelvin(double temperature)
        {
            return (temperature - 32) * 5 / 9 + 273.15;
        }
    }
}
