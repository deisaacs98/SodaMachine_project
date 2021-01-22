using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {
        //Intro message that asks user if they wish to make a purchase
        public static bool DisplayWelcomeInstructions(List<Can> sodaOptions)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Graphic.DisplaySodaMachineGraphic();
            PrintOptions(sodaOptions);
            bool willProceed = ContinuePrompt("\n\t\t\t\t\tDo you want to buy a soda? (y/n)");
            if (willProceed == true)
            {
                Console.Clear();
                return true;
            }
            else
            {
                OutputText("Then stop standing in front of the soda machine.");
                return false;
            }
        
        }
        //For printing out an error message for user to see.  Has built in console clear
        public static void DisplayError(string error)
        {
            Console.WriteLine(error);
            Console.ReadLine();
            Console.Clear();
        }
        //Method for getting user input for the selected coin.
        //Uses a tuple to help group valadation boolean and normalized selection name.
        public static string CoinSelection(Can selectedCan, List<Coin> payment, List<Coin> wallet,CreditCard creditCard)
        {

            Tuple<bool, string> validatedSelection;
            do
            {

                DisplayCost(selectedCan);
                DiplayTotalValueOfCoins(payment,wallet,creditCard);



                Console.WriteLine("\n");
                Console.WriteLine("Enter -1- for Quarter");
                Console.WriteLine("Enter -2- for Dime");
                Console.WriteLine("Enter -3- for Nickel");
                Console.WriteLine("Enter -4- for Penny");
                Console.WriteLine("Enter -5- for Credit Card");
                Console.WriteLine("Enter -6- when finished to deposit payment");



                int.TryParse(Console.ReadLine(), out int selection);
                if(selection==5)
                {
                    return "Credit Card";
                }
                validatedSelection = ValidateCoinChoice(selection);
               
            }
            while (!validatedSelection.Item1);
            

            return validatedSelection.Item2;

        }
        //For validating the selected coin choice. Returns a tuple with a bool for if its a valid input and the normalized name of the coin
        private static Tuple<bool, string> ValidateCoinChoice(int input)
        {
            switch (input)
            {
                case 1:
                    Console.Clear();
                    return Tuple.Create(true, "Quarter");
                case 2:
                    Console.Clear();
                    return Tuple.Create(true, "Dime");
                case 3:
                    Console.Clear();
                    return Tuple.Create(true, "Nickel");
                case 4:
                    Console.Clear();
                    return Tuple.Create(true, "Penny");
                case 5:
                    Console.Clear();
                    return Tuple.Create(true, "Credit Card");
                case 6:
                    Console.Clear();
                    return Tuple.Create(true, "Done");
                default:
                    DisplayError("Not a valid selection\n\nPress enter to continue");
                    return Tuple.Create(false, "Null");
            }
        }
        //Takes in a list of sodas and returns only unqiue sodas from it.
        public static List<Can> GetUniqueCans(List<Can> SodaOptions)
        {
            List<Can> UniqueCans = new List<Can>();
            List<string> previousNames = new List<string>();
            foreach (Can can in SodaOptions)
            {
                if (previousNames.Contains(can.Name))
                {
                    continue;
                }
                else
                {
                    UniqueCans.Add(can);
                    previousNames.Add(can.Name);
                }
            }
            return UniqueCans;

        }
        //Takes in a list of sodas to print.
        public static void PrintOptions(List<Can> SodaOptions)
        {
           Console.WriteLine("\n\t\t\t\t\t\tHere's what they got...");
           List<Can> uniqueCans = GetUniqueCans(SodaOptions);
           foreach(Can can in uniqueCans)
           {

                Console.WriteLine($"\t\t\t\t\t{can.Name}");
                //can.DisplayLogo();
           }
        }
        //Takes in the inventory of sodas to provide the user with an interface for their selection.
        public static string SodaSelection(List<Can> SodaOptions)
        {
            Tuple<bool, string> validatedSodaSelection;
            List<Can> uniqueCans = GetUniqueCans(SodaOptions);
            int selection;


            do
            {
                
                
                
                Console.WriteLine("\nPlease choose from the following.");
                
                for (int i = 0; i < uniqueCans.Count; i++)
                {

                    string price = String.Format("{0:C}", uniqueCans[i].Price);
                    Console.WriteLine($"\n\t\t\t\t\t\t\tEnter -{i + 1}- for {uniqueCans[i].Name} :  "+price);
                
                }
            
                



                int.TryParse(Console.ReadLine(), out selection);
                validatedSodaSelection = ValidateSodaSelection(selection, uniqueCans);
            
            
            } while (!validatedSodaSelection.Item1);


            return validatedSodaSelection.Item2;
           
        }
        //Uses a tuple to validate the soda selection.
        private static Tuple<bool,string> ValidateSodaSelection(int input, List<Can> uniqueCans)
        {
            if(input >= 0 && input <= uniqueCans.Count)
            {
                return Tuple.Create(true, uniqueCans[input-1].Name);
            }
            else
            {
                DisplayError("Not a valid selection\n\nPress enter to continue");
                return Tuple.Create(false, "Null");
            }
        }
        //Takes in a string to output to the console.
        public static void OutputText(string output)
        {
            Console.WriteLine(output);
        }














        //Used for any user prompts that use a yes or now format.

        public static bool ContinuePrompt(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "y":
                case "yes":
                    return true;
                case "n":
                case "no":
                    return false;
                default:
                    OutputText("Invalid input");
                    return ContinuePrompt(output);
            }
        }
        //Displays the cost of a can.
        public static void DisplayCost(Can selectedSoda)
        {
            Console.Clear();

            string price = String.Format("{0:C}", selectedSoda.Price);
            Console.WriteLine($"\nYou have selected {selectedSoda.Name}.  This option will cost "+price+" \n");
        }
        //Displays the total value of a list of coins.
        public static void DiplayTotalValueOfCoins(List<Coin> coinsToTotal1,List<Coin> coinsToTotal2, CreditCard creditCard)
        {
            double totalValue1 = 0;
            double totalValue2 = 0;
            foreach (Coin coin in coinsToTotal1)
            {
                totalValue1 += coin.Worth;
            }
            foreach (Coin coin in coinsToTotal2)
            {
                totalValue2 += coin.Worth;
            }

            string price1 = String.Format("{0:C}", totalValue1);

            string price2 = String.Format("{0:C}", totalValue2);
            string price3 = String.Format("{0:C}", creditCard.Worth);
            Console.WriteLine($"You currently have "+price1+" in hand");
            Console.WriteLine($"You currently have " + price2 + " in your wallet");
            Console.WriteLine($"You currently have " +price3 + " available on your credit card");
        }
        //Used for any error messages.  Has a built in read line for readablity and console clear after.
        public static void EndMessage(string sodaName, double changeAmount)
        {
            Console.WriteLine($"Enjoy your {sodaName}.");
            if(changeAmount > 0)
            {
                string change = String.Format("{0:C}", changeAmount);
                Console.WriteLine($"Despensing "+change);
            }
            Console.ReadLine();
        }

        public static void EndMessage(string sodaName)
        {
            Console.WriteLine($"\n\t\t\t\tEnjoy your {sodaName}.");
            Console.WriteLine("\n\t\t\t\t\tPlease take your card.");
            Console.ReadLine();
        }
    }
}
