using System;
using System.Collections.Generic;

// base class
abstract class WareHouseItem
{
    public string Name {get; set; }
}

// derived classes
class Electronics : WareHouseItem {}
class Groceries : WareHouseItem {}
class Furniture : WareHouseItem {}

// generic storage with constant
class Storage<T> where T : WareHouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach(var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }
}

class Program
{
    static void Main(String[] args)
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics {Name = "Gaming Laptop"});
        electronicsStorage.DisplayItems();
    }
}
