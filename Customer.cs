using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        private int chanceOfBuying;
        private int randomNumber;
        private bool purchase = false;
        private Random rnd;
        public int ChanceOfBuying
        {
            get { return chanceOfBuying; }
            set { chanceOfBuying = value; }
        }
        public bool Purchase
        {
            get { return purchase; }
            set { purchase = value; }
        }
        //constructor
        public Customer(Random rnd, Weather weather, Recipe recipe)
        {
            ChanceOfBuying = 2;  
            ChanceOfBuying = rnd.Next(1, 50);
            AccountForWeather(weather);
            AccountForIngredients(rnd, recipe);
        }
        //member methods

        public void AccountForWeather(Weather weather)
        {
            switch (weather.Atmosphere)
            {
                case "tornado":
                    Console.WriteLine("░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄");
                    Console.WriteLine("░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄");
                    Console.WriteLine("░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█");
                    Console.WriteLine("░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█");
                    Console.WriteLine("░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█");
                    Console.WriteLine("█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█");
                    Console.WriteLine("█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█");
                    Console.WriteLine("░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█");
                    Console.WriteLine("░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█");
                    Console.WriteLine("░░░█░░██░░▀█▄▄▄█▄▄█▄████░█");
                    Console.WriteLine("░░░░█░░░▀▀▄░█░░░█░███████░█");
                    Console.WriteLine("░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█");
                    Console.WriteLine("░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█");
                    Console.WriteLine("░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█");
                    Console.WriteLine("░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█");
                    break;
                case "clear":
                    ChanceOfBuying += 20;
                    break;
                case "partly cloudy":
                    ChanceOfBuying += 15;
                    break;
                case "overcast":
                    ChanceOfBuying -= 15;
                    break;
                case "precipitation":
                    ChanceOfBuying -= 20;
                    break;
            }
        }
        public void AccountForCost(decimal cost)
        {
            ChanceOfBuying /= (int)cost;
        }
        public void AccountForIngredients(Random rnd, Recipe recipe)
        {
            int preference = rnd.Next(1,4);
            switch (preference)
            {
                case 1:
                    if(recipe.LemonsNeeded > 2)
                    {
                        ChanceOfBuying += 30;
                    }
                    break;
                case 2:
                    if(recipe.IceCubesNeeded > 2)
                    {
                        ChanceOfBuying += 30;
                    }
                    break;
                case 3:
                    if(recipe.SugarUnitsNeeded > 2)
                    {
                        ChanceOfBuying += 40;
                    }
                    break;
            }
        }
        public bool CheckWillBuy()
        {
            if(chanceOfBuying > 50)
            {
                Console.Write("Yes! ");
                return true;
            }
            Console.WriteLine("No!");
            return false;
        }
    }
}
