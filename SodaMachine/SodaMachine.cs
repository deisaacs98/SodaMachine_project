using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A)
        private List<Coin> _register;
        private List<Can> _inventory;
        

        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>();
            _inventory = new List<Can>();

            for (int i = 0; i < 10; i++)
            {
                
                Dime dime = new Dime();
                
                FillRegister(dime);
                
            }
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
               
                Nickel nickel = new Nickel();
                
                Cola cola = new Cola();
                OrangeSoda orangeSoda = new OrangeSoda();
                RootBeer rootBeer = new RootBeer();
                FillRegister(quarter);
                
                FillRegister(nickel);
                
                FillInventory(cola);
                FillInventory(orangeSoda);
                FillInventory(rootBeer);
            }
            for (int i = 0; i < 50; i++)
            {
                
                Penny penny = new Penny();
                
                FillRegister(penny);
                
            }
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.
        public void FillRegister(Coin coin)
        {
            _register.Add(coin);

        }
        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory(Can can)
        {
            _inventory.Add(can);
        }
        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {  
                Transaction(customer);             
            }
        }
        
        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)
        {
            string sodaName = UserInterface.SodaSelection(_inventory);
            Can soda = GetSodaFromInventory(sodaName);
            List<Coin> wallet = customer.Wallet.Coins;
            List<Coin> payment =  customer.GatherCoinsFromWallet(soda,customer.Wallet.creditCard);
            string coin = UserInterface.CoinSelection(soda,payment,wallet,customer.Wallet.creditCard);
            if (coin == "Credit Card")
            {
                CalculateTransaction(customer.Wallet.creditCard, soda);
                customer.AddCanToBackpack(soda);
                UserInterface.EndMessage(sodaName);
            }
            else
            {
                double change = CalculateTransaction(payment, soda, customer);
                customer.AddCanToBackpack(soda);
                UserInterface.EndMessage(sodaName, change);
            }
            
        }
        //Gets a soda from the inventory based on the name of the soda.
        private Can GetSodaFromInventory(string nameOfSoda)
        {
            foreach(Can soda in _inventory)
            {
                if(soda.Name==nameOfSoda)
                {
                    return soda;
                }
            }
            return null;

        }

        //This is the main method for calculating the result of the transaction.
        //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
        //This is the method that will determine the following:
        //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Dispense soda, and change to the customer.
        //If the payment is greater than the cost of the soda, but the machine does not have ample change: Dispense payment back to the customer.
        //If the payment is exact to the cost of the soda:  Dispense soda.
        //If the payment does not meet the cost of the soda: dispense payment back to the customer.

        private void CalculateTransaction(CreditCard creditCard, Can chosenSoda)
        {
            double price = chosenSoda.Price;
            creditCard.WithdrawFunds(price);
        }

        private double CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
        {
            DepositCoinsIntoRegister(payment);
            double total = TotalCoinValue(payment);
            double price = chosenSoda.Price;
            double change = DetermineChange(total, price);
            List<Coin> change1 = GatherChange(change);
            double totalChange = TotalCoinValue(change1);
            if (change == totalChange)
            {
                customer.AddCoinsIntoWallet(change1);      
            }
            else
            {
                customer.AddCoinsIntoWallet(payment); 
            }
            return change;
        }





        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to despense.
        //If the change cannot be made, return null.



        //GatherChange algorithm is quite long. Consider refactoring.
        private List<Coin> GatherChange(double changeValue)
        {
            List<Coin> change = new List<Coin>();
            Coin coin;
            while (changeValue>=0.25)
            {
                if(RegisterHasCoin("Quarter"))
                {
                    coin = GetCoinFromRegister("Quarter");
                    change.Add(coin);
                    changeValue -= .25;
                }
                else if(RegisterHasCoin("Dime"))
                {
                    coin = GetCoinFromRegister("Dime");
                    change.Add(coin);
                    changeValue -= .1;
                }
                else if (RegisterHasCoin("Nickel"))
                {
                    coin = GetCoinFromRegister("Nickel");
                    change.Add(coin);
                    changeValue -= .05;
                }
                else if (RegisterHasCoin("Penny"))
                {
                    coin = GetCoinFromRegister("Penny");
                    change.Add(coin);
                    changeValue -= .01;
                }
                else
                {
                    return null;
                }
            
            }
            while (changeValue >= 0.1)
            {
                if (RegisterHasCoin("Dime"))
                {
                    coin = GetCoinFromRegister("Dime");
                    change.Add(coin);
                    changeValue -= .1;
                }
                else if (RegisterHasCoin("Nickel"))
                {
                    coin = GetCoinFromRegister("Nickel");
                    change.Add(coin);
                    changeValue -= .05;
                }
                else if (RegisterHasCoin("Penny"))
                {
                    coin = GetCoinFromRegister("Penny");
                    change.Add(coin);
                    changeValue -= .01;
                }
                else
                {
                    return null;
                }
            }
            while (changeValue >= 0.05)
            {
                if (RegisterHasCoin("Nickel"))
                {
                  coin = GetCoinFromRegister("Nickel");
                  change.Add(coin);
                   changeValue -= .05;
                }
                else if (RegisterHasCoin("Penny"))
                {
                    coin = GetCoinFromRegister("Penny");
                    change.Add(coin);
                    changeValue -= .01;
                }
                else
                {
                return null;
                }
            }
            while (changeValue >= 0.01)
            {
                if (RegisterHasCoin("Penny"))
                {
                    coin = GetCoinFromRegister("Penny");
                    change.Add(coin);
                    changeValue -= .01;
                }
                else
                {
                return null;
                }
            }
            return change;
        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {
            bool hasCoin=false;
            foreach(Coin coin in _register)
            {
                if (coin.Name==name)
                {
                    hasCoin = true;
                }    
            }
            return hasCoin;
        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {
            Coin coin = new Coin();
            coin.Name = name;
            _register.Remove(coin);
            return coin;
        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange(double totalPayment, double canPrice)
        {
            double temp = 0;
            double change = totalPayment - canPrice;
            if(change>0)
            {
                return change;
            }
            else
            {
                return temp;
            }
        }
        //Takes in a list of coins to returnt he total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {
           double value = 0;
           foreach(Coin coin in payment)
            {
                value += coin.Worth;
            }
            return value;
        }
        //Puts a list of coins into the soda machines register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {
           foreach(Coin coin in coins)
            {
                _register.Add(coin);
            }
        }
    }
}
