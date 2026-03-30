namespace UnitTestingPractice.Core;

public class BankAccount
{
    private double _balance;

    public void Deposit(double amount)
    {
        if (amount <= 0) throw new ArgumentException();
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds");
        _balance -= amount;
    }

    public double GetBalance() => _balance;
}
