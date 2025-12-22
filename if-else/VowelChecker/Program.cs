using System;

namespace VowelCheckerApp
{
    class Program
    {
        static void Main()
        {
            string x = "h";

            if (x == "a" || x == "e" || x == "i" || x == "o" || x == "u")
            {
                Console.WriteLine($"{x} is a vowel");
            }
            else
            {
                Console.WriteLine($"{x} is not a vowel");
            }
        }
    }
}
