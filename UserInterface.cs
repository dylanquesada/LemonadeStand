using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        // member variables

        //constructor
        public UserInterface()
        {

        }

        // member methods
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public int GetUserIntInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStoreRequest(string type)
        {
            Console.WriteLine("How many {0} would you like to purchase?", type);
        }
    }
}
