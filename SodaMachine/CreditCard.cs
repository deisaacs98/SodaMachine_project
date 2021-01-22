using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class CreditCard:Coin
    {
        
        public CreditCard()
        {
            worth = 0;
            Name = "Credit Card";
        }

        public override void DepositFunds(double amount)
        {
            worth += amount;
        }

        public override void WithdrawFunds(double amount)
        {
            worth -= amount;
        }
    }
}
