using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccountsClasses
{
    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal interestRate) : base(customer, interestRate) { }

        public void DrawMoney(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Invalid money value");
            }

            if (money <= this.Balance)
            {
                this.ballance -= money;
            }
            else
            {
                throw new ArgumentException("Not available as much money in the account !");
            }
        }
    }
}
