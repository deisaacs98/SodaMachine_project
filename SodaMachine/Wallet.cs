using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;
        public CreditCard creditCard;
        
        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            
            
            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money

        
        private void FillRegister()
        {
            creditCard = new CreditCard();
            creditCard.DepositFunds(10.00);
            for (int i = 0; i < 20; i++)
            {
                Penny penny = new Penny();
                Nickel nickel = new Nickel();
                Dime dime = new Dime();
                Quarter quarter = new Quarter();
                Coins.Add(penny);
                Coins.Add(nickel);
                Coins.Add(dime);
                Coins.Add(quarter);


            }

        }
    }
}
