using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39__tp.Classes
{
    internal class Helpers
    {
        public static void TextColor(string color, string chaine)
        {
            Console.Clear();
            ConsoleColor consoleColor;
            if (Enum.TryParse<ConsoleColor>(color, out consoleColor))
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine($"{chaine}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Invalid color: {color}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DisplayArray(string[] array)
        {
            foreach (string x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
