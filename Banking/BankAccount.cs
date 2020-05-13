using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Banking
{
    public abstract class BankAccount
    {
        public double Balance { get; protected set; }

        public virtual double Withdraw(double amount)
        {
            if(amount > Balance || amount < 0)
            {
                throw new InvalidOperationException();
            }
            Balance -= amount;
            return amount;
        }

        public virtual void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException();
            }
            Balance += amount;
        }

    }
}
