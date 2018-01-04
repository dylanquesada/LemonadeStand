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
        private int numberOfTurns = 7;
        public int NumberOfTurns
        {
            get { return numberOfTurns; }
            set { numberOfTurns = value; }
        }
        //constructor
        public Game()
        {
            Player player = new Player();
            rnd = new Random();
        }

        //member methods
        public void RunGame()
        {
            //Initial Menu -- get name, number of days to play
            Console.WriteLine("Welcome to Lemonade Stand.");
            //Loop
            for (int i = 0; i < numberOfTurns; i++)
            {

            }
                //Set Recipe, Set Cost, Buy Stuff
                //Run Day
                //Display Details

        }
    }
}
