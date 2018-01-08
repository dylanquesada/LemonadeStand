using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // member variables
        private string option;
        private int lemonsNeeded;
        private int sugarUnitsNeeded;
        private int iceCubesNeeded;
        private decimal price;

        //accessor for member variables

        public int LemonsNeeded
        {
            get { return lemonsNeeded; }
            set { lemonsNeeded = value; }
        }
        public int SugarUnitsNeeded
        {
            get { return sugarUnitsNeeded; }
            set { sugarUnitsNeeded = value; }
        }
        public int IceCubesNeeded
        {
            get { return iceCubesNeeded; }
            set { iceCubesNeeded = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
                  
        // constructor

        public Recipe()
        {
            LemonsNeeded = 1;
            SugarUnitsNeeded = 10;
            IceCubesNeeded = 1;
            price = .25m;
        }

        // member methods
        public bool HasEnoughIngredients(Inventory inventory)
        {
            if (inventory.NumberOfLemons > LemonsNeeded
                && inventory.NumberOfIceCubes > IceCubesNeeded
                && inventory.NumberOfSugarUnits > SugarUnitsNeeded)
            {
                return true;
            }
            return false;
        }
        public void SetRecipe(UserInterface userInterface)
        {
            option = "";
            while(!(option == "done")) { 
            Console.WriteLine("What would you like to change in the recipe? Enter 'lemons', 'ice cubes', or 'sugar units'. Enter 'done' to exit.");
                option = Console.ReadLine();
                switch (option)
                {
                    case "done":
                        break;
                    case "lemons":
                        Console.WriteLine("How many {0} per pitcher?", option);
                        LemonsNeeded = userInterface.GetUserIntInput();                        
                        break;
                    case "ice cubes":
                        Console.WriteLine("How many {0} per pitcher?", option);
                        IceCubesNeeded = userInterface.GetUserIntInput();
                        break;
                    case "sugar units":
                        Console.WriteLine("How many {0} per pitcher?", option);
                        SugarUnitsNeeded = userInterface.GetUserIntInput();
                        break;
                    default:
                        Console.WriteLine("Sorry, '{0}' is not a valid entry. Please try again.", option);
                        break;
                }
            }
        }
    }
}


