using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class Graphic
    {

        public static void GraphicWrite(bool newLine, ConsoleColor foregroundColor, ConsoleColor backgroundColor,string inputString)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            if (newLine)
            {
                Console.Write("\n"+inputString);
            }
            else
            {
                Console.Write(inputString);
            }

        }
        public static void DisplaySodaMachineGraphic()
        {
            string blank = new string(' ',40);
            string blank1 = new string(' ', 30);
            string blank2 = new string(' ', 8);
            string blank3 = new string(' ', 2);

            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, "\n"+blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);

            // User Interface


            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank1);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Gray, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank1);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Gray, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank1);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Gray, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);


            //Soda Selection Buttons


            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, "   _____                                ");
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, "  /    /                                ");
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, " /  __/____ ___   __          ");
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.DarkRed, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);

            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, " |__  |    |   | /  |                   ");
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, "  /   |  | | | |/ - |         ");
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Yellow, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
             
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, " /___/|____|___/_/__|                   ");
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, "                              ");
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Blue, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);

            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank1);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Green, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);

            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);

            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank1);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.DarkGray, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);

            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank1);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Magenta, blank2);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank3);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);




            //Can Dispenser

            string blank4 = new string(' ', 14);
            string blank5 = new string(' ', 12);

            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank4);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Black, blank5);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank4);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank4);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Black, blank5);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank4);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank4);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Black, blank5);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank4);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);



            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(true, ConsoleColor.White, ConsoleColor.Cyan, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Red, blank);
            GraphicWrite(false, ConsoleColor.Black, ConsoleColor.Cyan, blank);




        }
        public static void ColaLogo()
        {
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("WOLF COLA");
            Console.BackgroundColor = ConsoleColor.Cyan;

        }
        public static void OrangeLogo()
        {
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            
        }
        public static void RootBeerLogo()
        {
            Console.WriteLine("\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            
        }
    }
}
