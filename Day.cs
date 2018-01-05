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
        
        private int temperatureCustomerModifier = 2;
        private Weather weather;
        public Weather Weather
        {
            get { return weather; }
            set { weather = value; }
        }

        //constructor
        public Day(Random rnd)
        {
           weather = new Weather(rnd);
        }
        //member methods
        private int GenerateNumberOfCustomers(Weather weather)
        {
            return weather.Temperature * temperatureCustomerModifier;
        }

        private List<Customer> GenerateCustomersToList(int customers, Weather weather, Random rnd)
        {
            List<Customer> listOfCustomers = new List<Customer>();
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer(rnd, weather.Temperature);
                listOfCustomers.Add(customer);
            }
            return listOfCustomers;
        }
        public void RunDay(Weather weather, Random rnd)
        {
            List<Customer> today = GenerateCustomersToList(GenerateNumberOfCustomers(weather), weather, rnd);
            for (int i = 0; i < today.Count; i++)
            {
                if (today[i].CheckWillBuy())
                {
                    Console.WriteLine("1234");
                }
                // if(customer will buy){
                // cups made --;
                //money ++
            //}

            }
        }
    }
}
