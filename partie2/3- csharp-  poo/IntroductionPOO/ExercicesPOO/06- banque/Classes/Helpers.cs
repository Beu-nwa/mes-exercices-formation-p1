using System.Text.RegularExpressions;

namespace _06__banque.Classes
{
    public static class Helpers
    {
        public static double ConvertPurcentage(double x)
        {
            return Math.Round(x / 100, 2);
        }
        public static void ToCyan( string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ToGreen(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ToBlue(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ToRed(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static bool IsFirstName(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z]{2,}$");
        }

        public static bool IsLastName(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z]+( [a-zA-Z]+)*$");
        }
        public static bool IsPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, "^(\\+33\\s?\\d{2}\\s?\\d{2}\\s?\\d{2}\\s?\\d{2}\\s?\\d{2}|\\d{2}\\s?\\d{2}\\s?\\d{2}\\s?\\d{2}\\s?\\d{2})$");
        }
    }
}
