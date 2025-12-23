using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Method 2: Using a loop to convert an array to a List
        int [] arr = { 1, 2, 3, 4, 5};

        // Convert array to List
        List<int> numbers = new List<int>();

        foreach (int n in arr)
        {
            numbers.Add(n);
        }

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    

        Console.WriteLine("-----");
        // remove comment to test Method 1             
        // Method 1: Using List constructor to convert an array to a List
        /*int[] arr = { 1, 2, 3, 4, 5};

        // Convert array to List
        List<int> numbers = new List<int>(arr);

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        } */
    
    
    }   


}