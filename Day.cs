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

        private decimal dailyProfit;
        private int dailySales;
        private int temperatureCustomerModifier = 2;
        private Weather weather;
        public Weather Weather
        {
            get { return weather; }
            set { weather = value; }
        }
        public decimal DailyProfit
        {
            get { return dailyProfit; }
            set { dailyProfit = value; }
        }
        public int DailySales
        {
            get { return dailySales; }
            set { dailySales = value; }
        }

        //constructor
        public Day(Random rnd)
        {
            DailyProfit = 0m;
            DailySales = 0;
           weather = new Weather(rnd);
        }
        //member methods
        private int GenerateNumberOfCustomers(Weather weather)
        {
            return weather.Temperature * temperatureCustomerModifier;
        }

        private List<Customer> GenerateCustomersToList(int customers, Weather weather, Random rnd, Player player)
        {
            List<Customer> listOfCustomers = new List<Customer>();
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer(rnd, weather, player.Recipe);
                listOfCustomers.Add(customer);
            }
            return listOfCustomers;
        }
        private void DisplayEndOfDay(Player player)
        {
            Console.WriteLine("Cups sold: {0}", DailySales);
            Console.WriteLine("Today's Profit: {0}", DailyProfit);
            player.Inventory.DisplayInventory(player.Inventory, player);
        }
        public decimal RunDay(Weather weather, Random rnd, Player player)
        {
            List<Customer> today = GenerateCustomersToList(GenerateNumberOfCustomers(weather), weather, rnd, player);
            for (int i = 0; i < today.Count; i++)
            {
                if(player.Inventory.PreparedLemonade > 0)
                {
                    if (today[i].CheckWillBuy())
                    {
                        player.SellCup(player.Recipe.Price);
                        DailySales++;
                        DailyProfit += player.Recipe.Price;
                    }
                }
                else if (player.Recipe.HasEnoughIngredients(player.Inventory))
                {
                    if (today[i].CheckWillBuy())
                    {
                        player.MakeLemonade();
                        player.SellCup(player.Recipe.Price);
                        DailySales++;
                        DailyProfit += player.Recipe.Price;

                    }
                }
                else
                {
                    DisplayEndOfDay(player);
                    return DailyProfit;
                }            
            }
            DisplayEndOfDay(player);
            return DailyProfit;
        }
    }
}
