using System;

public class BankClient{
    public static string BankName = "Mathura Bank";
    public static string BranchName = "Mathura";
    public static string CifPrefix = "MATHURA-CIF";

    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }
    public string CifNumber { get; set; }

    public BankClient(string accountNumber, string name, double balance){
        AccountNumber = accountNumber;
        AccountHolderName = name;
        Balance = balance;
        CifNumber = CifPrefix + "-" + accountNumber;
    }

    public void ShowBalance(){
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("CIF: " + CifNumber);
        Console.WriteLine("Name: " + AccountHolderName);
        Console.WriteLine("Branch: " + BranchName);
        Console.WriteLine("Balance: " + Balance);
    }
}

public static class Bank{
    public static void Deposit(BankClient client, double amount){
        client.Balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public static void Withdraw(BankClient client, double amount){
        if(amount <= client.Balance){
            client.Balance -= amount;
            Console.WriteLine("Withdrew: " + amount);
        }
        else{
            Console.WriteLine("Low balance");
        }
    }
}

public class BankManager{
    private BankClient[] accounts = new BankClient[20];
    private int count;

    public void OpenAccount(){
        Console.Write("Account Number: "); string accNo = Console.ReadLine();
        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Balance: "); double bal; double.TryParse(Console.ReadLine(), out bal);
        if(count < 20 && FindAccount(accNo) == null){
            accounts[count++] = new BankClient(accNo, name, bal);
            Console.WriteLine("Account opened");
        }
    }

    public void DeleteAccount(){
        Console.Write("Account Number: "); string accNo = Console.ReadLine();
        int index = FindIndex(accNo);
        if(index != -1){
            for(int i = index; i < count - 1; i++)
                accounts[i] = accounts[i + 1];
            count--;
            Console.WriteLine("Account deleted");
        }
    }

    public BankClient FindAccount(string accNo){
        for(int i = 0; i < count; i++){
            if(accounts[i] != null && accounts[i].AccountNumber == accNo)
                return accounts[i];
        }
        return null;
    }

    private int FindIndex(string accNo){
        for(int i = 0; i < count; i++){
            if(accounts[i] != null && accounts[i].AccountNumber == accNo)
                return i;
        }
        return -1;
    }

    public void RunManager(){
        Console.WriteLine("\nMANAGER");
        Console.WriteLine("1.Open Account 2.Delete Account");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();
        if(choice == "1") OpenAccount();
        else if(choice == "2") DeleteAccount();
    }

    public void RunClient(){
        Console.Write("Account Number: ");
        string accNo = Console.ReadLine();
        BankClient client = FindAccount(accNo);
        if(client == null){
            Console.WriteLine("Account not found");
            return;
        }

        Console.WriteLine("\nCLIENT");
        Console.WriteLine("1.Deposit 2.Withdraw 3.Balance");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();
        
        if(choice == "1"){
            Console.Write("Amount: "); double amt; double.TryParse(Console.ReadLine(), out amt);
            Bank.Deposit(client, amt);
        }
        else if(choice == "2"){
            Console.Write("Amount: "); double amt; double.TryParse(Console.ReadLine(), out amt);
            Bank.Withdraw(client, amt);
        }
        else if(choice == "3"){
            client.ShowBalance();
        }
    }
}

public class Program{
    public static void Main(){
        BankManager manager = new BankManager();
        while(true){
            Console.WriteLine("\n" + BankClient.BankName);
            Console.WriteLine("1.Manager 2.Client");
            Console.Write("Role: ");
            string role = Console.ReadLine();
            if(role == "1") manager.RunManager();
            else if(role == "2") manager.RunClient();
        }
    }
}
