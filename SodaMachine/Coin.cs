using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Coin
    {
        //Member Variables (Has A)
        protected double worth;
        public string Name;

        public double Worth
        {
            get { return worth; }

        }

        


        //Constructor (Spawner)
        public Coin()
        {
            
        }

        //Member Methods (Can Do)
        public virtual void DepositFunds(double amount)
        {
            
        }

        public virtual void WithdrawFunds(double amount)
        {
            
        }
    }
}

