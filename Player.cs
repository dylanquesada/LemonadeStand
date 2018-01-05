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
        UserInterface userInterface;
        public Inventory inventory;
        public Inventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        private decimal money = 20;
        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //constructor
        public Player()
        {
            userInterface = new UserInterface();
            inventory = new Inventory();
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
            Money += cupPrice * cupsSold;
        }
        public decimal GiveMoney(decimal moneySpent, decimal money)
        {
            return money - moneySpent;
        }
        private decimal EarnMoney(decimal moneyEarned, decimal money)
        {
            return moneyEarned + money;
        }
    }
}
