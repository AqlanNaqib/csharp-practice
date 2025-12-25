using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         string [] validFruits = { "apple", "guava", "mango", "orange", "papaya"};

         List<string> fruits = new List<string>();
         string next = "";
         int[] counts = new int[5];

         Console.WriteLine("\nPopluate the list");

        do
        {
            Console.WriteLine("Enter a fruit only apple, guava, mango, orange, papaya or end to end");
            next = Console.ReadLine();
            bool isValidFruit = false;
            
            for (int i = 0; i < 5; i++)
            {
              if (validFruits[i] == next)
                {
                    fruits.Add(next);
                    isValidFruit = true;
                    counts[i] = counts[i] + 1;
                    break;
                }   
            }

            if ((!isValidFruit) && (next != "end"))
            {
                Console.WriteLine("Enter only apple, guava, mango, orange, papaya or end to end");
            }

        } while (next != "end");

        Console.WriteLine("\nDisplay the list");
        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nSearch the list and remove the fruit");
        Console.WriteLine("Which fruit shall we search for?");
        string search = Console.ReadLine();
        for (int i  = 0; i < 5; i++)
        {
            if (validFruits[i] == search)
            {
                Console.WriteLine("{0} entered {1} times", search, counts[i]);
                break;
            }
        }

        fruits.RemoveAll(f => f == search);
        
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);   
        }

        Console.WriteLine("\nSort the list");
        fruits.Sort();
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);   
        }

        Console.WriteLine("\nReverse the list");
        fruits.Reverse();
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nReplace apples with blueberries");
        int numOfApples = counts[0];
        fruits.Reverse();
        fruits.RemoveAll(f => f == "apple");
        for (int i =0; i<numOfApples; ++i)
        {
            fruits.Add("blueberry");
        }

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

    } // Main
} // Program
