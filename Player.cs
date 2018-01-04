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

        }
        //member methods
        public void BuyCups()
        {
            //money -= 
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
