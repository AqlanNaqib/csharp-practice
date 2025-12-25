using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Menu Calculator");
        Console.WriteLine("Select option (1-4):");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice: ");

        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Please select a number between 1 to 4.");
            return;
        }

        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        double result;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case 2:
                result= num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

    }
}