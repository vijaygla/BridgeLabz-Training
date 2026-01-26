using System;

// Node class
class ItemNode
{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int itemId, string itemName, int quantity, double price)
    {
        ItemId = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

// Singly Linked List class
class InventoryLinkedList
{
    private ItemNode head;

    // Add at beginning
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = head;
        head = newNode;
    }

    // Add at end
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Add at specific position (1-based)
    public void AddAtPosition(int position, int id, string name, int qty, double price)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }

        ItemNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }

        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Remove by Item ID
    public void RemoveByItemId(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty");
            return;
        }

        if (head.ItemId == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed");
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed");
        }
    }

    // Update quantity by Item ID
    public void UpdateQuantity(int id, int newQty)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }

    // Search by Item ID
    public void SearchByItemId(int id)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                PrintItem(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }

    // Search by Item Name
    public void SearchByItemName(string name)
    {
        ItemNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.ItemName.Equals(name))
            {
                PrintItem(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Item not found");
    }

    // Total inventory value
    public void TotalInventoryValue()
    {
        double total = 0;
        ItemNode temp = head;

        while (temp != null)
        {
            total = total + (temp.Price * temp.Quantity);
            temp = temp.Next;
        }

        Console.WriteLine("Total Inventory Value: " + total);
    }

    // Sort by Item Name
    public void SortByName(bool ascending)
    {
        for (ItemNode i = head; i != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                int result = i.ItemName.CompareTo(j.ItemName);
                if ((ascending && result > 0) || (!ascending && result < 0))
                {
                    SwapData(i, j);
                }
            }
        }
        Console.WriteLine("Inventory sorted by name");
    }

    // Sort by Price
    public void SortByPrice(bool ascending)
    {
        for (ItemNode i = head; i != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                {
                    SwapData(i, j);
                }
            }
        }
        Console.WriteLine("Inventory sorted by price");
    }

    // Display inventory
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No items in inventory");
            return;
        }

        ItemNode temp = head;
        while (temp != null)
        {
            PrintItem(temp);
            temp = temp.Next;
        }
    }

    // Swap node data
    private void SwapData(ItemNode a, ItemNode b)
    {
        int id = a.ItemId;
        string name = a.ItemName;
        int qty = a.Quantity;
        double price = a.Price;

        a.ItemId = b.ItemId;
        a.ItemName = b.ItemName;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.ItemId = id;
        b.ItemName = name;
        b.Quantity = qty;
        b.Price = price;
    }

    // Print item
    private void PrintItem(ItemNode item)
    {
        Console.WriteLine(
            "ID: " + item.ItemId +
            ", Name: " + item.ItemName +
            ", Qty: " + item.Quantity +
            ", Price: " + item.Price
        );
    }
}

// Main class
class InventoryManagementSystem
{
    static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();

        inventory.AddAtEnd(1, "Keyboard", 10, 500);
        inventory.AddAtBeginning(2, "Mouse", 20, 300);
        inventory.AddAtPosition(2, 3, "Monitor", 5, 8000);

        Console.WriteLine("Inventory:");
        inventory.Display();

        Console.WriteLine("\nSearch by ID:");
        inventory.SearchByItemId(3);

        Console.WriteLine("\nUpdate Quantity:");
        inventory.UpdateQuantity(1, 15);

        Console.WriteLine("\nTotal Value:");
        inventory.TotalInventoryValue();

        Console.WriteLine("\nSort by Name Ascending:");
        inventory.SortByName(true);
        inventory.Display();

        Console.WriteLine("\nSort by Price Descending:");
        inventory.SortByPrice(false);
        inventory.Display();
    }
}
