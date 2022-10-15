using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class currentAccount : BankAccount
    {
        private double kamat = 1.5;
        public void caclculateCharges()
        {
            base.updateBalance((decimal)((double)base.returnBalance() * this.kamat));
        }
        public decimal interestCharges()
        {
            return base.returnBalance();
        }
    }
}
