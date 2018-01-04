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
        private int GenerateNumberOfCustomers(Weather weather)
        {
            return weather.Temperature * TemperatureCustomerModifier;
        }

        private List<Customer> GenerateCustomersToList(int customers)
        {
            List<Customer> listOfCustomers = new List<Customer>();
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer();
                listOfCustomers.Add(customer);
            }
            return listOfCustomers;
        }
    }
}
