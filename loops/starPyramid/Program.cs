using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Star Pyramid");

        for(int i=1; i<=5; i++)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


    }

}