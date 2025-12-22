using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (number % 5 == 0)
            Console.WriteLine($"{number} is divisible by 5");
        else
            Console.WriteLine($"{number} is not divisible by 5");
    }
}
