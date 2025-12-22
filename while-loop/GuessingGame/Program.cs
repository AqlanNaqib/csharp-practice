using System;

namespace GuessingGameApp
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int magicNumber = rand.Next(0, 11);
            bool correct = false;

            Console.WriteLine("Guess the number (0–10)");

            while (!correct)
            {
                Console.Write("Enter guess: ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (guess < magicNumber)
                    Console.WriteLine("Too low");
                else if (guess > magicNumber)
                    Console.WriteLine("Too high");
                else
                {
                    Console.WriteLine("Correct!");
                    correct = true;
                }
            }
        }
    }
}
