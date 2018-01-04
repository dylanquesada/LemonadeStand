using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        private int TemperatureCustomerModifier = 2;
        private int numberOfCustomers;

        //constructor
        public Day()
        {
            Weather weather = new Weather();
        }
        //member methods
        public int GenerateNumberOfCustomers(Weather weather)
        {
            return weather.Temperature * TemperatureCustomerModifier;
        }
    }
}
