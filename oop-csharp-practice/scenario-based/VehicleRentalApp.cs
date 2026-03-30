using System;

// Interface for rentable vehicles - Abstraction
public interface IRentable
{
    double CalculateRent(int days);
}

// Base Vehicle class - Encapsulation with protected fields
public abstract class Vehicle : IRentable
{
    protected string vehicleId;
    protected string brand;
    protected double baseRatePerDay;
    protected bool isAvailable;

    public Vehicle(string vehicleId, string brand, double baseRatePerDay)
    {
        this.vehicleId = vehicleId;
        this.brand = brand;
        this.baseRatePerDay = baseRatePerDay;
        this.isAvailable = true;
    }

    public string VehicleId 
    { 
        get { return vehicleId; } 
    }
    public string Brand 
    { 
        get { return brand; } 
    }
    public bool IsAvailable 
    { 
        get { return isAvailable; } 
    }

    public abstract double CalculateRent(int days);

    public void MarkAsRented()
    {
        isAvailable = false;
    }
    public void MarkAsAvailable()
    {
        isAvailable = true;
    }
}

// Bike class - Inheritance
public class Bike : Vehicle
{
    protected int engineCapacity;

    public Bike(string vehicleId, string brand, int engineCapacity) 
        : base(vehicleId, brand, 500.0)
    {
        this.engineCapacity = engineCapacity;
    }

    public override double CalculateRent(int days)
    {
        double discount = (days > 7) ? 0.1 : 0;
        return baseRatePerDay * days * (1 - discount);
    }
}

// Car class - Inheritance
public class Car : Vehicle
{
    protected int seats;
    protected bool hasAC;

    public Car(string vehicleId, string brand, int seats, bool hasAC) 
        : base(vehicleId, brand, 1500.0)
    {
        this.seats = seats;
        this.hasAC = hasAC;
    }

    public override double CalculateRent(int days)
    {
        double acPremium = hasAC ? 200.0 : 0;
        double totalRate = (baseRatePerDay + acPremium) * days;
        if (days > 3) totalRate = totalRate * 0.95;
        return totalRate;
    }
}

// Truck class - Inheritance
public class Truck : Vehicle
{
    protected double loadCapacityTons;

    public Truck(string vehicleId, string brand, double loadCapacityTons) 
        : base(vehicleId, brand, 3000.0)
    {
        this.loadCapacityTons = loadCapacityTons;
    }

    public override double CalculateRent(int days)
    {
        double rate = baseRatePerDay * days;
        if (loadCapacityTons > 5) rate = rate * 1.2;
        return rate;
    }
}

// Customer class - Encapsulation
public class Customer
{
    private string customerId;
    private string name;
    private string phone;
    private string address;

    public Customer(string customerId, string name, string phone, string address)
    {
        this.customerId = customerId;
        this.name = name;
        this.phone = phone;
        this.address = address;
    }

    public string GetDetails()
    {
        return "ID: " + customerId + ", Name: " + name + ", Phone: " + phone;
    }
}

// Main Rental Application - Fixed for C# 5
class VehicleRentalApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to Mathura Vehicle Rental Service");
        Console.WriteLine("=====================================");

        // Fixed array inventory (NO collections)
        Vehicle[] inventory = new Vehicle[6];
        inventory[0] = new Bike("B001", "Hero", 150);
        inventory[1] = new Bike("B002", "Bajaj", 125);
        inventory[2] = new Car("C001", "Maruti", 5, true);
        inventory[3] = new Car("C002", "Hyundai", 4, true);
        inventory[4] = new Truck("T001", "Tata", 3.5);
        inventory[5] = new Truck("T002", "Ashok Leyland", 7.0);

        Customer[] customers = new Customer[3];
        customers[0] = new Customer("CUST001", "Rahul Sharma", "9876543210", "Mathura");
        customers[1] = new Customer("CUST002", "Priya Singh", "9876543211", "Vrindavan");
        customers[2] = new Customer("CUST003", "Amit Kumar", "9876543212", "Agra");

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Available Vehicles:");
            DisplayInventory(inventory);
            
            Console.WriteLine("");
            Console.WriteLine("1. Rent Vehicle");
            Console.WriteLine("2. Return Vehicle");
            Console.WriteLine("3. Calculate Rental Cost");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice (1-5): ");

            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                RentVehicle(inventory, customers[0]);
            }
            else if (choice == "2")
            {
                ReturnVehicle(inventory);
            }
            else if (choice == "3")
            {
                CalculateRentalCost(inventory);
            }
            else if (choice == "4")
            {
                DisplayCustomers(customers);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using Mathura Vehicle Rental!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
            
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void DisplayInventory(Vehicle[] inventory)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            string status = inventory[i].IsAvailable ? "Available" : "Rented";
            Console.WriteLine((i+1) + ". " + inventory[i].Brand + " " + inventory[i].VehicleId + " - " + status);
        }
    }

    static void RentVehicle(Vehicle[] inventory, Customer customer)
    {
        Console.Write("Enter vehicle number (1-6): ");
        string input = Console.ReadLine();
        int vehicleNum;
        if (int.TryParse(input, out vehicleNum) && vehicleNum >= 1 && vehicleNum <= 6)
        {
            vehicleNum--;
            if (inventory[vehicleNum].IsAvailable)
            {
                Console.WriteLine(customer.GetDetails() + " rented " + inventory[vehicleNum].Brand);
                inventory[vehicleNum].MarkAsRented();
            }
            else
            {
                Console.WriteLine("Vehicle already rented!");
            }
        }
        else
        {
            Console.WriteLine("Invalid vehicle number!");
        }
    }

    static void ReturnVehicle(Vehicle[] inventory)
    {
        Console.Write("Enter vehicle number (1-6): ");
        string input = Console.ReadLine();
        int vehicleNum;
        if (int.TryParse(input, out vehicleNum) && vehicleNum >= 1 && vehicleNum <= 6)
        {
            vehicleNum--;
            inventory[vehicleNum].MarkAsAvailable();
            Console.WriteLine("Vehicle returned successfully!");
        }
        else
        {
            Console.WriteLine("Invalid vehicle number!");
        }
    }

    static void CalculateRentalCost(Vehicle[] inventory)
    {
        Console.Write("Enter vehicle number (1-6): ");
        string vInput = Console.ReadLine();
        Console.Write("Enter rental days: ");
        string dInput = Console.ReadLine();

        int vehicleNum, days;
        if (int.TryParse(vInput, out vehicleNum) && int.TryParse(dInput, out days) 
            && vehicleNum >= 1 && vehicleNum <= 6 && days > 0)
        {
            vehicleNum--;
            double cost = inventory[vehicleNum].CalculateRent(days);
            Console.WriteLine("Total Rental Cost: " + cost + " for " + days + " days");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    static void DisplayCustomers(Customer[] customers)
    {
        Console.WriteLine("Customer List:");
        for (int i = 0; i < customers.Length; i++)
        {
            Console.WriteLine((i+1) + ". " + customers[i].GetDetails());
        }
    }
}
