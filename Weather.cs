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
        private int forecastedTemperature;
        private string forecastedAtmosphere;
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
        public string ForecastedAtmosphere
        {
            get { return forecastedAtmosphere; }
            set { forecastedAtmosphere = value; }
        }
        private List<string> atmospheres = new List<string> {
            "precipitation",
            "overcast",
            "partly cloudy",
            "clear" };
        public int ForecastedTemperature
        {
            get { return forecastedTemperature; }
            set { forecastedTemperature = value; }
        }
        //constructor
        public Weather(Random rnd)
        {
            GenerateAtmosphere(rnd);
            Temperature = generateTemperature(rnd);
            WeatherForecaster(rnd);
            AtmosphericForecaster(rnd);
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
        private void WeatherForecaster(Random rnd)
        {
            ForecastedTemperature = rnd.Next((Temperature - 5), (Temperature + 5));
        }
        private void AtmosphericForecaster(Random rnd)
        {
            if (rnd.Next(1, 100) > 33) {
                ForecastedAtmosphere = Atmosphere;
            }
            else
            {
                ForecastedAtmosphere = "overcast";
            }
        }

    }
}
