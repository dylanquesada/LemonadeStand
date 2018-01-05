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
        string option;
        Random rnd;
        Store store;
        UserInterface userInterface;
        private bool ready = false;
        private int numberOfTurns = 7;
        public int NumberOfTurns
        {
            get { return numberOfTurns; }
            set { numberOfTurns = value; }
        }
        //constructor
        public Game()
        {
            userInterface = new UserInterface();


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
                option = "";
                while (!ready)
                {
                    Console.WriteLine("What would you like to do? Enter a keyword: 'recipe', 'store', 'go'");
                    switch (Console.ReadLine())
                    {
                        case "store":
                            store.RunStore(player);
                            break;
                        case "recipe":
                            player.Recipe.SetRecipe(userInterface);
                            break;
                        case "go":
                            ready = true;
                            break;
                        default:
                            Console.WriteLine("Sorry, '{0}' is not a valid entry. Try again.", option);
                            option = userInterface.GetUserInput();
                            break;
                    }
                }
                Day day = new Day(rnd);
                //Display Details
            }
        }
    }
}


                //Set Recipe, Set Cost, Buy Stuff
                //Run Day


