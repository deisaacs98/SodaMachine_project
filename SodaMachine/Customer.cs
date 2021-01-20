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
        private List<Coin> coinsInWallet = new List<Coin>();

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
            
            foreach(Coin coin1 in coinsInWallet)
            {
                totalCash += coin1.Value;
            }

            if(totalCash<price)
            {
                return null;
            }
            while (paymentValue < price)
            {
                string coinName = UserInterface.CoinSelection(selectedCan, coinsInWallet);
                Coin coin = GetCoinFromWallet(coinName);
                payment.Add(coin);
                paymentValue += coin.Value;
                totalCash -= coin.Value;
            }

            return payment;



        }
        //Returns a coin object from the wallet based on the name passed into it.
        //Returns null if no coin can be found
        public Coin GetCoinFromWallet(string coinName)
        {
            Coin coin = new Coin();
            coin.Name = coinName;
            if(coinsInWallet.Contains(coin))
            {
                coinsInWallet.Remove(coin);
                return coin;
            }
            else
            {
                return null;
            }
        }
        //Takes in a list of coin objects to add into the customers wallet.
        public void AddCoinsIntoWallet(List<Coin> coinsToAdd)
        {
            foreach (Coin coin in coinsToAdd)
            {
                coinsInWallet.Add(coin);
            }
        }
        //Takes in a can object to add to the customers backpack.
        public void AddCanToBackpack(Can purchasedCan)
        {
            Backpack.cans.Add(purchasedCan);
        }
    }
}
