using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Task1
    {
           public class BankAccount
            {
            private string accountNumber;
            private double balance;
            
            public string AccountNumber
            {
                get { return accountNumber; }
            }
            public double Balance
            {
                get { return balance; }
                private set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Balance cannot be negative.");
                    }
                    balance = value;

                }
            }
            public BankAccount(string accountNumber, double initialBalance)
            {
                this.accountNumber = accountNumber;
                Balance = initialBalance;
            }
            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
            }
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds for this withdrawal.");
                }
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
            }
        }
    }
}
 