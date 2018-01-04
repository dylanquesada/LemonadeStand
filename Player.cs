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
        private decimal money;
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
            Inventory inventory = new Inventory();
            SetUserName();
        }
        //member methods
        private void SetUserName()
        {
            Console.WriteLine("Enter name for player:");
            Name = userInterface.GetUserInput();
        }
        public void BuyStuff(decimal stuffCost, int quantity)
        {
            Money = GiveMoney(stuffCost * quantity, Money);
        }
        public void SellCups(decimal cupPrice, int cupsSsold)
        {
            Money += cupPrice * cupsSsold;
        }
        private decimal GiveMoney(decimal moneySpent, decimal money)
        {
            return money - moneySpent;
        }
        private decimal EarnMoney(decimal moneyEarned, decimal money)
        {
            return moneyEarned + money;
        }
    }
}
