using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccountsClasses
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal interestRate) : base(customer, interestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if ((this.Customer.type == CustomerType.Individual) && (months <= 6))
            {
                return 0;
            }

            if ((this.Customer.type == CustomerType.Company) && (months <= 12))
            {
                return (this.InterestRate * months) / 2;
            }

            return this.InterestRate * months;
        }
    }
}
