using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class BankAccount
    {
        private string accountNo;
        private decimal balance;
        public decimal returnBalance()
        {
            return balance;
        }
        public void updateBalance(decimal osszeg)
        {
            balance += osszeg;
        }

    }
}
