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
        private int numberOfIcecubes;
        private int numberOfSugarUnits;
        public int NumberOfCups
        {
            get
            {
                return numberOfCups;
            }
            set
            {
                numberOfCups = value;
            }
        }
        public int NumberOfLemons
        {
            get
            {
                return numberOfLemons;
            }
            set
            {
                numberOfLemons = value;
            }
        }
        public int NumberOfIcecubes
        {
            get
            {
                return numberOfIcecubes;
            }
            set
            {
                numberOfIcecubes = value;
            }
        }
        public int NumberOfSugarUnits
        {
            get
            {
                return numberOfSugarUnits;
            }
            set
            {
                numberOfSugarUnits = value;
            }
        }

        //constructor
        public Inventory()
        {

        }

        //member methods
        public void AddToInventory(int quantity, string type)
        {
            switch (type)
            {
                case "cups":

                    break;
                case "lemons":

                    break;
                case "ice":

                    break;
                case "sugar":

                    break;
                default:
                    break;
            }
        }
    }
}
