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
        private int TemperatureCustomerModifier = 2;
        private int numberOfCustomers;

        //constructor
        public Day(Random rnd)
        {
            Weather weather = new Weather(rnd);
        }
        //member methods
        private int GenerateNumberOfCustomers(Weather weather)
        {
            return weather.Temperature * TemperatureCustomerModifier;
        }

        private List<Customer> GenerateCustomersToList(int customers)
        {
            List<Customer> listOfCustomers = new List<Customer>();
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer(rnd);
                listOfCustomers.Add(customer);
            }
            return listOfCustomers;
        }
    }
}
