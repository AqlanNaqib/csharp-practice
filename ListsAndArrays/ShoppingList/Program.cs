using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> ShoppingList = new List<string>();

        ShoppingList.Add("Apple");
        ShoppingList.Add("Banana");
        ShoppingList.Add("Banana"); //mistake duplicate
        ShoppingList.Add("Dumpling");

       ShoppingList.RemoveAt(2); // remove the duplicate Banana and im using index removal
       ShoppingList.Insert(2, "Carrot"); // insert Carrot at index 2

       Console.WriteLine("Shopping List:");

       foreach (string item in ShoppingList)
        {
            Console.WriteLine(item);
        }
    }
}