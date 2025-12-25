using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Student Grade Calculator!");

        Console.Write("Enter your score (0-100): ");
        
        if (!int.TryParse (Console.ReadLine(), out int score) || score < 0 || score > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 to 100.");
            return;
        }

        if (score >= 90)
        {
            Console.WriteLine("Your grade is A+");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your grade is A");
        }
        else if ( score >= 70)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (score >= 50)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (score >= 40)
        {
            Console.WriteLine(" Your grade is E");
        }
        else
        {
            Console.WriteLine("Your Grade is F");
        }
    }
}