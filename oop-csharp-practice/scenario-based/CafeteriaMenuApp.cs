using System;

class CafeteriaMenuApp {
    static void Main() {
        string[] menuItems = new string[10] {
            "Veg Sandwich",
            "Chicken Burger",
            "Paneer Roll",
            "French Fries",
            "Masala Dosa",
            "Veg Biryani",
            "Chicken Biryani",
            "Pasta",
            "Coffee",
            "Tea"
        };

        Console.WriteLine("===Available Menu===");
        DisplayMenu(menuItems);

        Console.Write("Select any menu index: ");
        int index = int.Parse(Console.ReadLine());
        string orderedMenu = GetItemByIndex(index, menuItems);

        if(orderedMenu != null) {
            Console.WriteLine("you ordered: " + orderedMenu);
        }
        else {
            Console.WriteLine("Sorry this menu not availble");
        }
    }

    // method to display the menu item in the cafetaria
    public static void DisplayMenu(string[] menuItems) {
        for(int i=0; i < menuItems.Length; i++) {
            Console.WriteLine((i+1) + " --> " + menuItems[i]);
        }
    }

    // to get the item of menu
    public static string GetItemByIndex(int index, string[] menuItems) {
        if(index >= 1 && index <= menuItems.Length) {
            return menuItems[index-1];
        }
        return "Enter any valid index (1-10)";
    }
}
