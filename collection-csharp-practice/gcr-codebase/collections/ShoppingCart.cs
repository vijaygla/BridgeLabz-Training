using System;
using System.Collections.Generic;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();

        cart.Add("Laptop", 50000);
        cart.Add("Mouse", 800);
        cart.Add("Keyboard", 1500);

        SortedDictionary<double, string> sortedByPrice = new SortedDictionary<double, string>();

        foreach (var item in cart)
        {
            sortedByPrice[item.Value] = item.Key;
        }

        Console.WriteLine("Items Sorted by Price:");
        foreach (var item in sortedByPrice)
        {
            Console.WriteLine($"{item.Value} : {item.Key}");
        }
    }
}
