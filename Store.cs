using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables
        private string option;
        private int costOfCups;
        private int costOfLemons;
        private int costOfIceCubes;
        private int costOfSugarUnits;
        public int CostOfCups
        {
            get { return costOfCups; }
            set { costOfCups = value; }
        }
        public int CostOfLemons
        {
            get { return costOfLemons; }
            set { costOfLemons = value; }
        }
        public int CostOfIcecubes
        {
            get { return costOfIceCubes; }
            set { costOfIceCubes = value; }
        }
        public int CostOfSugarUnits
        {
            get { return costOfSugarUnits; }
            set { costOfSugarUnits = value; }
        }
        private UserInterface userInterface = new UserInterface();
        //constructor
        public Store()
        {
            
        }
        //member methods
        public void DisplayStore(Player player)
        {
            option = "";
            while (!(option == "done"))
            {
                Console.WriteLine("Welcome to the Store. Enter keyword for purchasing or 'Done' to Continue.");
                option = userInterface.GetUserInput();
                switch (option)
                {
                    case "done":
                        option = "done";
                        break;
                    case "cups":
                        userInterface.DisplayStoreRequest(option);
                        player.BuyStuff(costOfCups , CollectQuantityRequested());
                        break;
                    case "lemons":
                        userInterface.DisplayStoreRequest(option);
                        player.BuyStuff(costOfLemons, CollectQuantityRequested());
                        break;
                    case "sugar units":
                        userInterface.DisplayStoreRequest(option);
                        player.BuyStuff(costOfSugarUnits, CollectQuantityRequested());
                        break;
                    case "ice cubes":
                        userInterface.DisplayStoreRequest(option);
                        player.BuyStuff(costOfIceCubes, CollectQuantityRequested());
                        break;
                    default:
                        Console.WriteLine("Sorry, '{0}' is not a valid keyword. Please try again.", option);
                        DisplayStore(player);
                        break;
                }
            }
        }
        private void DisplayBuyOptions(string type)
        {
            userInterface.DisplayStoreRequest(type);
        }
        private int CollectQuantityRequested()
        {
            return userInterface.GetUserIntInput();
        }
       
    }
}
