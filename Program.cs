using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            // game.RunGame();
            Inventory test = new Inventory();
            UserInterface t = new UserInterface();
            test.AlterInventory(3, "cups");
            test.DisplayInventory(test);
            Console.Read();
        }
        

    }
}
