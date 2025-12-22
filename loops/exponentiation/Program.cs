using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base number: ");
        if (!int.TryParse(Console.ReadLine(), out int baseNumber))
        {
            Console.WriteLine("Invalid base number");
            return;
        }

        Console.Write("Enter the power: ");
        if (!int.TryParse(Console.ReadLine(), out int power))
        {
            Console.WriteLine("Invalid power");
            return;
        }

        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= baseNumber;
        }

        Console.WriteLine($"{baseNumber} raised to the power of {power} is {result}");
    }
}
