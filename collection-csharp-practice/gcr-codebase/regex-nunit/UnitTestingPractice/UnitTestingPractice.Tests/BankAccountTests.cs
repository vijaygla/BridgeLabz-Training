using UnitTestingPractice.Core;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Withdraw_InsufficientFunds_Throws()
    {
        var acc = new BankAccount();
        acc.Deposit(100);

        Assert.Throws<InvalidOperationException>(() => acc.Withdraw(200));
    }
}
