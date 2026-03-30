using System;

class BankAccount
{
    double balance = 5000;

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }

        if (amount > balance)
        {
            throw new Exception("Insufficient balance!");
        }

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }

    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            account.Withdraw(2000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
