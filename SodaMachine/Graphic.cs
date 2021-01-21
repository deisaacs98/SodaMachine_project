using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class Graphic
    {
        public static void DisplaySodaMachineGraphic()
        {

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
