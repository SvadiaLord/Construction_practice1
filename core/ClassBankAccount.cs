using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public ClassBankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Недостаточно средств.");
        }
    }
}
