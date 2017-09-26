using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace UnitTestProject1
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [TestMethod]
        public void Withdraw_ValidAMount_ChangesBalance()
        {
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount("John Doe", currentBalance);
            account.Withdraw(withdrawal);
            double actual = account.Balance;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_AmountMoreTHanBalance_Throws()
        {
            var acount = new CheckingAccount("John Doe", 10.0);
            acount.Withdraw(20.0);
        }
    }
}
