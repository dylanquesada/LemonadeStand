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
        private decimal score = 0m;
        private int gameDay = 1;
        string option;
        public Random rnd;
        Store store;
        UserInterface userInterface;
        private bool ready = false;
        private int numberOfTurns = 7;
        public int NumberOfTurns
        {
            get { return numberOfTurns; }
            set { numberOfTurns = value; }
        }
        public int GameDay
        {
            get { return gameDay; }
            set { gameDay = value; }
        }
        public decimal Score
        {
            get { return score; }
            set { score = value; }
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
                    Console.WriteLine("What would you like to do? Enter a keyword: 'recipe', 'store', 'price', 'go'");
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
                        case "price":
                            Console.WriteLine("What would you like the price per cup of your lemonade to be?");
                            player.Recipe.Price = userInterface.GetUserDecimalInput();
                            break;
                        default:
                            Console.WriteLine("Sorry, '{0}' is not a valid entry. Try again.", option);
                            option = userInterface.GetUserInput();
                            break;
                    }
                }
                ready = false;
                Day day = new Day(rnd);
                Console.WriteLine("Day {0}:", GameDay);
                GameDay++;
                score += day.RunDay(day.Weather, rnd, player);
                //Display Details
                Console.WriteLine("{0}'s Net Profit: ${1}", player.Name, score);
            }
        }
    }
}


                //Set Recipe, Set Cost, Buy Stuff
                //Run Day


