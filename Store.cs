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
        private decimal costOfCups = .05m;
        private decimal costOfLemons = .5m;
        private decimal costOfIceCubes = .01m;
        private decimal costOfSugarUnits = .05m;
        
        public decimal CostOfCups
        {
            get { return costOfCups; }
            set { costOfCups = value; }
        }
        public decimal CostOfLemons
        {
            get { return costOfLemons; }
            set { costOfLemons = value; }
        }
        public decimal CostOfIcecubes
        {
            get { return costOfIceCubes; }
            set { costOfIceCubes = value; }
        }
        public decimal CostOfSugarUnits
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
                        player.BuyStuff(costOfCups, CollectQuantityRequested());
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
                Console.WriteLine("{0}'s wallet: ${1}",player.Name , player.Money);
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
        private bool ValidTransaction(Player player, decimal cost)
        {
            if (player.Money > cost)
            {
                return true;
            }
                return false;
        }    
    }
}
