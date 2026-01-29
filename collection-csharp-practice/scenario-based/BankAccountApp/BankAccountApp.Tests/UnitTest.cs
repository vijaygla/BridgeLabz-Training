using NUnit.Framework;
using NUnit.Framework.Legacy;
using BankAccountApp;
using System;

namespace BankAccountApp.Tests
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void Test_Deposit_ValidAmount()
        {
            Program account = new Program(1000);
            account.Deposit(500);

            ClassicAssert.AreEqual(1500, account.Balance);
        }

        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            Program account = new Program(1000);

            Exception ex = Assert.Throws<Exception>(() => account.Deposit(-200));
            ClassicAssert.AreEqual("Deposit amount cannot be negative", ex.Message);
        }

        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            Program account = new Program(1000);
            account.Withdraw(400);

            ClassicAssert.AreEqual(600, account.Balance);
        }

        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            Program account = new Program(500);

            Exception ex = Assert.Throws<Exception>(() => account.Withdraw(800));
            ClassicAssert.AreEqual("Insufficient funds.", ex.Message);
        }
    }
}
