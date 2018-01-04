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
        private int temperature;
        public int Temperature{
            get { return temperature; }
            set { temperature = value; }
        }
        private string atmosphere;
        private List<string> atmospheres = new List<string> {
            "Precipiation",
            "Overcast",
            "Partly Cloudy",
            "Clear" };
        
        //constructor
        public Weather(Random rnd)
        {
            temperature = generateTemperature(rnd);
        }

        //member methods
        private int generateTemperature(Random random)
        {
            temperature = random.Next(1, 110);
            return temperature;
        }

    }
}
