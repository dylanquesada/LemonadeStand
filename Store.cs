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
                        player.BuyCups();
                        break;
                    case "lemons":
                        Console.WriteLine("");
                        player.BuyLemons();
                        break;
                    case "sugar":
                        Console.WriteLine("");
                        Player.BuySugar();
                        break;
                    case "ice":
                        Player.BuyIce();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Sorry, '{0}' is not a valid keyword. Please try again.");
                        break;
                }
            }
        }
       
    }
}
