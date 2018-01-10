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
        private List<Day> days;
        private decimal score;
        private int gameDay;
        string option;
        public Random rnd;
        Store store;
        UserInterface userInterface;
        private bool ready;
        private int numberOfTurns;
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
            days = new List<Day>();
            score = 0m;
            gameDay = 1;
            ready = false;
            numberOfTurns = 7;
        }

        //member methods
        public void RunGame()
        {
            Player player = new Player();
            store = new Store();
            rnd = new Random();
            Console.WriteLine("Welcome to Lemonade Stand.");
            for (int i = 0; i < numberOfTurns; i++)
            {
                Day day = new Day(rnd);
                days.Add(day);
            }
            for(int i = 0; i < days.Count; i++)
            {
                
                Console.WriteLine("Day {0}:", GameDay);
                days[i].DisplayForecast(days[i].Weather);
                option = "";
                while (!ready)
                {
                    Console.WriteLine("What would you like to do? Enter a keyword: 'recipe', 'store', 'price', 'go'");
                    switch (Console.ReadLine())
                    {
                        case "forecast":
                            Weather.DisplayWeeklyForecast(days);
                            break;
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
                score += days[i].RunDay(days[i].Weather, rnd, player);
                //Day day = new Day(rnd);
                
                GameDay++;
                
                //Display Details
                Console.WriteLine("{0}'s Net Profit: ${1}", player.Name, score);

            }
            DatabaseConnection db = new DatabaseConnection();
            db.OpenConnection();
            db.ExecuteQueries("INSERT INTO lemonadestand.HighScores VALUES ('" + player.Name + "', " + Score + ");");
            db.CloseConnection();
        }
    }
}


                //Set Recipe, Set Cost, Buy Stuff
                //Run Day


