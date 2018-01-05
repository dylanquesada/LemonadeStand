using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        Random rnd;
        Store store;
        private int numberOfTurns = 7;
        public int NumberOfTurns
        {
            get { return numberOfTurns; }
            set { numberOfTurns = value; }
        }
        //constructor
        public Game()
        {
            
            
            
        }

        //member methods
        public void RunGame()
        {
            Player player = new Player();
            store = new Store();
            rnd = new Random();
            //Initial Menu -- get name, number of days to play
            Console.WriteLine("Welcome to Lemonade Stand.");
            //Loop
            for (int i = 0; i < numberOfTurns; i++)
            {
                store.RunStore(player);
                Day day = new Day(rnd);
            }
                //Set Recipe, Set Cost, Buy Stuff
                //Run Day
                //Display Details

        }
    }
}
