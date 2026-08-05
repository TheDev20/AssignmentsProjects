using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsProjects.Classes
{
    internal class BankAccount
    {
        private decimal _balance;

        public decimal Balance
        {
            set { _balance = value; }
            get { return _balance; }
        }

        public string Owner { get; set; }

        internal void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(amount),
                    "Deposit amount must be positive."
                );
            }
            _balance += amount;
        }

        internal void withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(amount),
                    "Withdrawal amount must be positive."
                );
            }
            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            _balance -= amount;
        }

        internal virtual string GetAccountType()
        {
            return "Standard";
        }
    }

    internal class SavingsAccount : BankAccount
    {
        internal static decimal _interestRate;

        public SavingsAccount(decimal interestRate)
        {
            _interestRate = interestRate;
        }

        public virtual void ApplyInterest()
        {
            decimal interest = Balance * _interestRate;
            Deposit(interest);
        }

        internal override string GetAccountType()
        {
            return "Savings";
        }
    }

    internal class PremiumSavingsAccount : SavingsAccount
    {
        public PremiumSavingsAccount(decimal interestRate)
            : base(interestRate) { }

        public override void ApplyInterest()
        {
            decimal interest = Balance * _interestRate;
            Deposit(interest);
            _interestRate = _interestRate * 2; // Double the interest rate for premium accounts
        }

        internal override string GetAccountType()
        {
            return "Premium Savings";
        }
    }
}
