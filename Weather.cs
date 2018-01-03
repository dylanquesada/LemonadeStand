using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        private int temperature {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        private string atmosphere;
        //private List<string> atmospheres = new List<string> {
       //     "Precipiation",
       //     "Overcast",
       //     "Partly Cloudy",
       //     "Clear" };
        Random rnd = new Random();
        //constructor
        public Weather()
        {
            this.temperature = generateTemperature();
        }

        //member methods
        private int generateTemperature()
        {
            temperature = rnd.Next(1, 110);
            return temperature;
        }

    }
}
