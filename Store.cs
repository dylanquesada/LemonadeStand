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
        public decimal CostOfIceCubes
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
        public void DisplayStore()
        {
            Console.WriteLine("Welcome to the Store. Enter keyword for purchasing or 'Done' to Continue.");
            Console.WriteLine("Cups: ${0}", CostOfCups);
            Console.WriteLine("Lemons: ${0}", CostOfLemons);
            Console.WriteLine("Sugar Units: ${0}", CostOfSugarUnits);
            Console.WriteLine("Ice Cubes: ${0}", CostOfIceCubes);

        }


        //TODO simplify RunStore (maybe move away from switch and use method that takes in 'option')
        public void RunStore(Player player)
        {
            option = "";
            int quantity;
            while (!(option == "done"))
            {
                player.Inventory.DisplayInventory(player.Inventory, player);
                DisplayStore();
                Console.WriteLine("{0}'s wallet: ${1}", player.Name, player.Inventory.Money);
                option = userInterface.GetUserInput();
                
                switch (option)
                {
                    case "done":
                        option = "done";
                        break;
                    case "cups":
                        userInterface.DisplayStoreRequest(option);
                        quantity = CollectQuantityRequested();
                        if (ValidTransaction(player, (quantity * CostOfCups)))
                        {
                            ExecuteTransaction(player.Inventory, CostOfCups, quantity, option);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you haven't the monies for the transaction requested.");
                        }
                        break;
                    case "lemons":
                        userInterface.DisplayStoreRequest(option);
                        quantity = CollectQuantityRequested();
                        if (ValidTransaction(player, (quantity * CostOfLemons)))
                        {
                            ExecuteTransaction(player.Inventory, CostOfLemons, quantity, option);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you haven't the monies for the transaction requested.");
                        }
                        break;
                    case "sugar units":
                        userInterface.DisplayStoreRequest(option);
                        quantity = CollectQuantityRequested();
                        if (ValidTransaction(player, (quantity * CostOfSugarUnits)))
                        {
                            ExecuteTransaction(player.Inventory, CostOfSugarUnits, quantity, option);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you haven't the monies for the transaction requested.");
                        }
                        break;
                    case "ice cubes":
                        userInterface.DisplayStoreRequest(option);
                        quantity = CollectQuantityRequested();
                        if (ValidTransaction(player, (quantity * CostOfIceCubes))) {
                            ExecuteTransaction(player.Inventory, CostOfIceCubes, quantity, option);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you haven't the monies for the transaction requested.");
                        }
                        break;
                    default:
                        Console.WriteLine("Sorry, '{0}' is not a valid keyword. Please try again.", option);
                        RunStore(player);
                        break;
                }
                Console.WriteLine("{0}'s wallet: ${1}", player.Name, player.Inventory.Money);
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
            if (player.Inventory.Money > cost)
            {
                return true;
            }
                return false;
        }
        public void ExecuteTransaction(Inventory inventory, decimal unitCost, int quantity, string option)
        {
            inventory.AlterInventory(quantity, option);
            inventory.AlterInventory(-(unitCost * quantity));
        }
        
    }
}
