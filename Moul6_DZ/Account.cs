using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moul6_DZ
{
    public class Account
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }
        private string Password;

        public Account(string accountNumber, string password)
        {
            AccountNumber = accountNumber;
            Password = password;
            Balance = 0;
        }

        public bool ValidatePassword(string password)
        {
            return Password == password;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
