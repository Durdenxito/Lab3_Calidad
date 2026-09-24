namespace Bank.WebApi.Models
{
    /// <summary>
    /// Represents a customer's bank account and its current balance.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        private BankAccount() { }

        /// <summary>
        /// Creates a bank account with an owner and an initial balance.
        /// </summary>
        /// <param name="customerName">Name of the account owner.</param>
        /// <param name="balance">Initial account balance.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Gets the name of the account owner.
        /// </summary>
        public string CustomerName { get { return m_customerName; } }

        /// <summary>
        /// Gets the current account balance.
        /// </summary>
        public double Balance { get { return m_balance; }  }

        /// <summary>
        /// Withdraws an amount from the account.
        /// </summary>
        /// <param name="amount">Amount to withdraw.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the amount is negative or exceeds the balance.</exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException("amount");
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance -= amount;
        }

        /// <summary>
        /// Adds an amount to the account balance.
        /// </summary>
        /// <param name="amount">Amount to add.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the amount is negative.</exception>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance += amount;
        }
    }
}