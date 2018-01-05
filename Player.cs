using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        private string name;
        UserInterface userInterface;
        Inventory inventory;
        Recipe recipe;
        public Inventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }
        //constructor
        public Player()
        {
            userInterface = new UserInterface();
            inventory = new Inventory();
            recipe = new Recipe();
            SetUserName();
        }
        //member methods
        private void SetUserName()
        {
            Console.WriteLine("Enter name for player:");
            Name = userInterface.GetUserInput();
        }
        
        public void SellCups(decimal cupPrice, int cupsSold)
        {
            Inventory.Money += cupPrice * cupsSold;
        }
        
        private decimal EarnMoney(decimal moneyEarned, decimal money)
        {
            return moneyEarned + money;
        }
        public void MakeLemonade()
        {

            if (Inventory.NumberOfLemons >.Recipe.LemonsNeeded
                && Inventory.NumberOfIceCubes > Recipe.IceCubesNeeded
                && Inventory.NumberOfSugarUnits > Recipe.SugarUnitsNeeded)
            {
                Inventory.PreparedLemonade++;
            }
        }
    }
}
