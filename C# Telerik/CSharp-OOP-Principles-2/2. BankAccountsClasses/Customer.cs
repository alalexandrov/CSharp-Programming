using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccountsClasses
{
    class Customer
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && value.Length > 1 && value.Length < 40)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid customer name !");
                }
            }
        }
        public CustomerType type { get; set; }

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.type = type;
        }
    }
}
