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
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<SugarUnit> sugarunits;
        public List<IceCube> icecubes;

        
        private decimal money;
        private int preparedLemonade;

       
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
            lemons = new List<Lemon>();
            cups = new List<Cup>();
            icecubes = new List<IceCube>();
            sugarunits = new List<SugarUnit>();

            PreparedLemonade = 0;
            Money = 20m;

        }

        //member methods
        public void AlterInventory(int quantity, string type)
        {
            if(quantity > 0) {
                switch (type)
                {
                    case "cups":
                        cups = cups.Cast<Cup>().Concat((AddItem(quantity, type)).Cast<Cup>()).ToList();
                        break;
                    case "lemons":
                        lemons = lemons.Cast<Lemon>().Concat((AddItem(quantity, type)).Cast<Lemon>()).ToList();
                        break;
                    case "ice cubes":
                        icecubes = icecubes.Cast<IceCube>().Concat((AddItem(quantity, type)).Cast<IceCube>()).ToList();
                        break;
                    case "sugar units":
                        sugarunits = sugarunits.Cast<SugarUnit>().Concat((AddItem(quantity, type)).Cast<SugarUnit>()).ToList();
                        break;
                    default:
                        break;
                }
            }
            else if(quantity < 0)
            {
                switch (type)
                {
                    case "cups":
                        cups = RemoveItem(quantity, type, cups.Cast<Item>().ToList()).Cast<Cup>().ToList();
                        break;
                    case "lemons":
                        lemons = RemoveItem(quantity, type, lemons.Cast<Item>().ToList()).Cast<Lemon>().ToList();
                        break;
                    case "ice cubes":
                        icecubes = RemoveItem(quantity, type, icecubes.Cast<Item>().ToList()).Cast<IceCube>().ToList();
                        break;
                    case "sugar units":
                        sugarunits = RemoveItem(quantity, type, sugarunits.Cast<Item>().ToList()).Cast<SugarUnit>().ToList();
                        break;
                    default:
                        break;
                }
            }
        }
        public void AlterInventory(decimal quantity)
        {
            Money += quantity;
        }
        public void DisplayInventory(Inventory inventory, Player player)
        {
            Console.WriteLine("{0}'s Inventory:", player.Name);
            Console.WriteLine("Cups: {0}", inventory.cups.Count);
            Console.WriteLine("Lemons: {0}", inventory.lemons.Count);
            Console.WriteLine("Sugar Units: {0}", inventory.sugarunits.Count);
            Console.WriteLine("Ice Cubes: {0}", inventory.icecubes.Count);
            Console.WriteLine("Money Remaining: ${0}", Money);
        }
        public void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Your Inventory:");
            Console.WriteLine("Cups: {0}", inventory.cups.Count);
            Console.WriteLine("Lemons: {0}", inventory.lemons.Count);
            Console.WriteLine("Sugar Units: {0}", inventory.sugarunits.Count);
            Console.WriteLine("Ice Cubes: {0}", inventory.icecubes.Count);
            Console.WriteLine("Money Remaining: ${0}", Money);
        }
        public List<Item> RemoveItem(int quantity, string type, List<Item> list)
        {
            for(int i = 0; i > quantity; i--)
            {
                list.RemoveAt(0);
            }
            return list;            
        }
        public List<Item> AddItem(int quantity, string type)
        {
            List<Item> list = new List<Item>();
            switch (type)
            {
                case "cups":
                    for(int i = 0; i < quantity; i++)
                    {
                        Cup cup = new Cup();
                        list.Add(cup);
                    }
                    return list;
                case "ice cubes":
                    for (int i = 0; i < quantity; i++)
                    {
                        IceCube iceCube = new IceCube();
                        list.Add(iceCube);
                    }
                    return list;
                case "sugar units":
                    for (int i = 0; i < quantity; i++)
                    {
                        SugarUnit sugarUnit = new SugarUnit();
                        list.Add(sugarUnit);
                    }
                    return list;
                case "lemons":
                    for(int i = 0; i < quantity; i++)
                    {
                        Lemon lemon = new Lemon();
                        list.Add(lemon);
                    }
                    return list;
                default:
                    return list;
            }
        }
    }
}
