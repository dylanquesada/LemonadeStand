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
        private string name;
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
