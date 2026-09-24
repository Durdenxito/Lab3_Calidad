using Bank.WebApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Domain.Tests
{
    /// <summary>
    /// Verifies the behavior of <see cref="BankAccount"/>.
    /// </summary>
    [TestClass]
    public class BankAccountTests
    {
        /// <summary>
        /// Verifies that debiting a valid amount updates the balance.
        /// </summary>
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // Act
            account.Debit(debitAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}