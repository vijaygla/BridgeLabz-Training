using System;

// Interface for Abstraction - IPayable for bills
public interface IPayable
{
    decimal GetPaymentAmount();
    void DisplayBill();
}

// Base Patient class with Encapsulation (private fields, public properties)
public class Patient
{
    private string id;
    private string name;
    private int age;
    private string contact;

    public string Id 
    { 
        get { return id; } 
        set { id = value; } 
    }
    public string Name 
    { 
        get { return name; } 
        set { name = value; } 
    }
    public int Age 
    { 
        get { return age; } 
        set { age = value; } 
    }
    public string Contact 
    { 
        get { return contact; } 
        set { contact = value; } 
    }

    public Patient(string id, string name, int age, string contact)
    {
        Id = id;
        Name = name;
        Age = age;
        Contact = contact;
    }

    // Virtual method for Polymorphism
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient ID: " + Id + ", Name: " + Name + ", Age: " + Age + ", Contact: " + Contact);
    }
}

// InPatient inherits from Patient
public class InPatient : Patient, IPayable
{
    private int roomNo;
    private int daysStay;
    private decimal roomRate = 5000m; // per day

    public int RoomNo 
    { 
        get { return roomNo; } 
        set { roomNo = value; } 
    }
    public int DaysStay 
    { 
        get { return daysStay; } 
        set { daysStay = value; } 
    }

    public InPatient(string id, string name, int age, string contact, int roomNo, int daysStay) 
        : base(id, name, age, contact)
    {
        RoomNo = roomNo;
        DaysStay = daysStay;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("InPatient - ID: " + Id + ", Name: " + Name + ", Age: " + Age + ", Contact: " + Contact + ", Room: " + RoomNo + ", Days: " + DaysStay);
    }

    public decimal GetPaymentAmount()
    {
        return DaysStay * roomRate;
    }

    public void DisplayBill()
    {
        Console.WriteLine("Bill for " + Name + ": Room charges = " + GetPaymentAmount());
    }
}

// OutPatient inherits from Patient
public class OutPatient : Patient, IPayable
{
    private decimal consultationFee = 1000m;
    private decimal medicineCost;

    public decimal MedicineCost 
    { 
        get { return medicineCost; } 
        set { medicineCost = value; } 
    }

    public OutPatient(string id, string name, int age, string contact, decimal medicineCost) 
        : base(id, name, age, contact)
    {
        MedicineCost = medicineCost;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("OutPatient - ID: " + Id + ", Name: " + Name + ", Age: " + Age + ", Contact: " + Contact + ", Medicine Cost: " + MedicineCost);
    }

    public decimal GetPaymentAmount()
    {
        return consultationFee + MedicineCost;
    }

    public void DisplayBill()
    {
        Console.WriteLine("Bill for " + Name + ": Consultation + Medicine = " + GetPaymentAmount());
    }
}

// Doctor class - separate class
public class Doctor
{
    private string docId;
    private string name;
    private string specialization;

    public string DocId { get { return docId; } set { docId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Specialization { get { return specialization; } set { specialization = value; } }

    public Doctor(string docId, string name, string specialization)
    {
        DocId = docId;
        Name = name;
        Specialization = specialization;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Doctor ID: " + DocId + ", Name: " + Name + ", Specialization: " + Specialization);
    }
}

// Nurse class - separate class
public class Nurse
{
    private string nurseId;
    private string name;
    private string department;

    public string NurseId { get { return nurseId; } set { nurseId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Department { get { return department; } set { department = value; } }

    public Nurse(string nurseId, string name, string department)
    {
        NurseId = nurseId;
        Name = name;
        Department = department;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Nurse ID: " + NurseId + ", Name: " + Name + ", Department: " + Department);
    }
}

// Bill class - implements IPayable for polymorphism
public class Bill : IPayable
{
    private string billId;
    private string description;
    private decimal amount;

    public string BillId { get { return billId; } set { billId = value; } }
    public string Description { get { return description; } set { description = value; } }
    public decimal Amount { get { return amount; } set { amount = value; } }

    public Bill(string billId, string description, decimal amount)
    {
        BillId = billId;
        Description = description;
        Amount = amount;
    }

    public decimal GetPaymentAmount()
    {
        return Amount;
    }

    public void DisplayBill()
    {
        Console.WriteLine("Bill ID: " + BillId + ", " + Description + " = " + Amount);
    }
}

// Main console app - NO COLLECTIONS used
class Program
{
    // Fixed slots instead of collections
    static Patient currentPatient1 = null;
    static Patient currentPatient2 = null;
    static int patientCount = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("=== Hospital Patient Management System ===");
        Console.WriteLine("1. Add Patient (Max 2)");
        Console.WriteLine("2. Display Current Patients");
        Console.WriteLine("3. Generate Bill for Patient");
        Console.WriteLine("4. Display Staff");
        Console.WriteLine("5. Exit");
        
        Doctor doc1 = new Doctor("D001", "Dr. Smith", "Cardiology");
        Nurse nurse1 = new Nurse("N001", "Jane Doe", "ICU");

        while (true)
        {
            Console.Write("\nEnter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (patientCount >= 2)
                {
                    Console.WriteLine("Max 2 patients allowed. Clear or select another option.");
                    continue;
                }
                Console.Write("Patient Type (1: InPatient, 2: OutPatient): ");
                string type = Console.ReadLine();
                Console.Write("ID: "); string id = Console.ReadLine();
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Age: "); int age = int.Parse(Console.ReadLine());
                Console.Write("Contact: "); string contact = Console.ReadLine();

                Patient p;
                if (type == "1")
                {
                    Console.Write("Room No: "); int room = int.Parse(Console.ReadLine());
                    Console.Write("Days Stay: "); int days = int.Parse(Console.ReadLine());
                    p = new InPatient(id, name, age, contact, room, days);
                }
                else
                {
                    Console.Write("Medicine Cost: "); decimal med = decimal.Parse(Console.ReadLine());
                    p = new OutPatient(id, name, age, contact, med);
                }
                
                if (patientCount == 0) currentPatient1 = p;
                else currentPatient2 = p;
                patientCount++;
                p.DisplayInfo(); // Polymorphism
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Current Patients ---");
                if (currentPatient1 != null) currentPatient1.DisplayInfo();
                if (currentPatient2 != null) currentPatient2.DisplayInfo();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nCurrent Patients:");
                if (currentPatient1 != null) Console.WriteLine("1. " + currentPatient1.Name);
                if (currentPatient2 != null) Console.WriteLine("2. " + currentPatient2.Name);
                
                if (patientCount == 0)
                {
                    Console.WriteLine("No patients.");
                    continue;
                }
                
                Console.Write("Select (1 or 2): "); int sel = int.Parse(Console.ReadLine());
                Patient selected = (sel == 1) ? currentPatient1 : currentPatient2;
                if (selected != null)
                {
                    IPayable payable = (IPayable)selected;
                    payable.DisplayBill();
                    Console.WriteLine("Total Payable: " + payable.GetPaymentAmount());
                    Console.Write("Paid? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.WriteLine("Payment successful!");
                        // Simulate clearing patient
                        if (sel == 1) { currentPatient1 = null; patientCount--; }
                        else { currentPatient2 = null; patientCount--; }
                    }
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("\n--- Staff ---");
                doc1.DisplayInfo();
                nurse1.DisplayInfo();
            }
            else if (choice == "5") break;
            else Console.WriteLine("Invalid choice.");
        }
        Console.WriteLine("Thank you for using Hospital Management System!");
    }
}
