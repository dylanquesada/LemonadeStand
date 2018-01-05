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
        private Random rnd;
        private int temperatureCustomerModifier = 2;
        private int numberOfCustomers;
        Weather weather;

        //constructor
        public Day(Random rnd)
        {
            Weather weather = new Weather(rnd);
        }
        //member methods
        private int GenerateNumberOfCustomers(Weather weather)
        {
            return weather.Temperature * temperatureCustomerModifier;
        }

        private List<Customer> GenerateCustomersToList(int customers, Weather weather)
        {
            List<Customer> listOfCustomers = new List<Customer>();
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer(rnd, weather.Temperature);
                listOfCustomers.Add(customer);
            }
            return listOfCustomers;
        }
        public void RunDay()
        {
            List<Customer> today = GenerateCustomersToList(GenerateNumberOfCustomers(weather), weather);
        }
    }
}
