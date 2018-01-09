using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables
        private int numberOfCups;
        private int numberOfLemons;
        private int numberOfIceCubes;
        private int numberOfSugarUnits;
        private decimal money;
        private int preparedLemonade;

        public int NumberOfCups
        {
            get { return numberOfCups; }
            set { numberOfCups = value; }
        }
        public int NumberOfLemons
        {
            get { return numberOfLemons; }
            set { numberOfLemons = value; }
        }
        public int NumberOfIceCubes
        {
            get { return numberOfIceCubes; }
            set { numberOfIceCubes = value; }
        }
        public int NumberOfSugarUnits
        {
            get { return numberOfSugarUnits; }
            set { numberOfSugarUnits = value; }
        }
        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }
        public int PreparedLemonade
        {
            get { return preparedLemonade; }
            set { preparedLemonade = value; }
        }

        //constructor
        public Inventory()
        {
            NumberOfCups = 0;
            NumberOfLemons = 0;
            NumberOfSugarUnits = 0;
            NumberOfIceCubes = 0;
            PreparedLemonade = 0;
            Money = 20m;

        }

        //member methods
        public void AlterInventory(int quantity, string type)
        {
            switch (type)
            {
                case "cups":
                    NumberOfCups += quantity;
                    break;
                case "lemons":
                    NumberOfLemons += quantity;
                    break;
                case "ice cubes":
                    NumberOfIceCubes += quantity;
                    break;
                case "sugar units":
                    NumberOfSugarUnits += quantity;
                    break;
                default:
                    break;
            }
        }
        public void AlterInventory(decimal quantity)
        {
            Money += quantity;
        }
        public void DisplayInventory(Inventory inventory, Player player)
        {
            Console.WriteLine("{0}'s Inventory:", player.Name);
            Console.WriteLine("Cups: {0}", NumberOfCups);
            Console.WriteLine("Lemons: {0}", NumberOfLemons);
            Console.WriteLine("Sugar Units: {0}", NumberOfSugarUnits);
            Console.WriteLine("Ice Cubes: {0}", NumberOfIceCubes);
            Console.WriteLine("Money Remaining: ${0}", Money);
        }
        public void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Your Inventory:");
            Console.WriteLine("Cups: {0}", NumberOfCups);
            Console.WriteLine("Lemons: {0}", NumberOfLemons);
            Console.WriteLine("Sugar Units: {0}", NumberOfSugarUnits);
            Console.WriteLine("Ice Cubes: {0}", NumberOfIceCubes);
            Console.WriteLine("Money Remaining: ${0}", Money);
        }
        
    }
}
