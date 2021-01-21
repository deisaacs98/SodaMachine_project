using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //Member Variables (Has A)
        public Wallet Wallet;
        public Backpack Backpack;
        

        //Constructor (Spawner)
        public Customer()
        {
            Wallet = new Wallet();
            Backpack = new Backpack();
        }
        //Member Methods (Can Do)

        //This method will be the main logic for a customer to retrieve coins form their wallet.
        //Takes in the selected can for price reference
        //Will need to get user input for coins they would like to add.
        //When all is said and done this method will return a list of coin objects that the customer will use a payment for their soda.
        public List<Coin> GatherCoinsFromWallet(Can selectedCan)
        {
            double totalCash = 0;
            List<Coin> payment=new List<Coin>();
            double paymentValue = 0;
            double price = selectedCan.Price;
            
            foreach(Coin coin1 in Wallet.Coins)
            {
                totalCash += coin1.Worth;
            }

            while (paymentValue < price)
            {
                string coinName = UserInterface.CoinSelection(selectedCan, payment,Wallet.Coins);
                Coin coin = GetCoinFromWallet(coinName);
                if(coin!=null)
                { 
                payment.Add(coin);
                
                paymentValue += coin.Worth;
                totalCash -= coin.Worth;
                }
            }

            return payment;



        }
        //Returns a coin object from the wallet based on the name passed into it.
        //Returns null if no coin can be found
        public Coin GetCoinFromWallet(string coinName)
        {
            foreach(Coin coin in Wallet.Coins)
            {
                if(coin.Name==coinName)
                {
                    Wallet.Coins.Remove(coin);
                    return coin;

                }
            }
            return null;
        }
        //Takes in a list of coin objects to add into the customers wallet.
        public void AddCoinsIntoWallet(List<Coin> coinsToAdd)
        {
            foreach (Coin coin in coinsToAdd)
            {
                Wallet.Coins.Add(coin);
            }
        }
        //Takes in a can object to add to the customers backpack.
        public void AddCanToBackpack(Can purchasedCan)
        {
            Backpack.cans.Add(purchasedCan);
        }
    }
}
