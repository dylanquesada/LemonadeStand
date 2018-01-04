﻿using System;
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
        public void AlterInventory(int quantity, string type)
        {
            switch (type)
            {
                case "cups":
                    NumberOfCups += quantity;
                    break;
                case "lemons":
                    numberOfLemons += quantity;
                    break;
                case "ice":
                    NumberOfIcecubes += quantity;
                    break;
                case "sugar":
                    NumberOfSugarUnits += quantity;
                    break;
                default:
                    break;
            }
        }
    }
}
