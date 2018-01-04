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
        private decimal money;
        public decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //constructor
        public Player()
        {
            Inventory inventory = new Inventory();

        }
        //member methods
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
