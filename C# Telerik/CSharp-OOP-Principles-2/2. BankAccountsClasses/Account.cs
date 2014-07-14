using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccountsClasses
{
    class Account
    {
        private Customer customer;
        protected decimal ballance;
        private decimal interestRate;

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value != null)
                {
                    this.customer = value;
                }
                else
                {
                    throw new ArgumentException("Customer can't be null value !");
                }
            }
        }
        public decimal Balance
        {
            get
            {
                return this.ballance;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value > 0)
                {
                    this.interestRate = value;
                }
                else
                {
                    throw new ArgumentException("Invalid interest rate !");
                }
            }
        }

        public Account(Customer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        public void Deposit(decimal money)
        {
            if (money > 0)
            {
                this.ballance += money;
            }
            else
            {
                throw new ArgumentException("Invalid deposit money value !");
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            if (months > 0)
            {
                return this.InterestRate * months;
            }
            else
            {
                throw new ArgumentException("Invalid interest months !");
            }    
        }
    }
}
