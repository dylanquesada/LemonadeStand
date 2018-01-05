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
        private int ChanceOfActOfGod = 10000000;
        private int MagicNumber = 42;
        private int temperature;
        public int Temperature{
            get { return temperature; }
            set { temperature = value; }
        }
        private string atmosphere;
        public string Atmosphere
        {
            get { return atmosphere; }
            set { atmosphere = value; }
        }
        private List<string> atmospheres = new List<string> {
            "precipiation",
            "overcast",
            "partly cloudy",
            "clear" };
        
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
        private void GenerateAtmosphere(Random rnd)
        {
            atmosphere = atmospheres[rnd.Next(1, 4)];
            if (rnd.Next(1, ChanceOfActOfGod) == MagicNumber)
            {
                atmosphere = "tornado";
            }
        }

    }
}
