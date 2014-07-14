using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccountsClasses
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal interestRate) : base(customer, interestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if ((months <= 3 && this.Customer.type == CustomerType.Individual) ||
                (months <= 2 && this.Customer.type == CustomerType.Company))
            {
                return 0;
            }

            return this.InterestRate * months;
        }
    }
}
