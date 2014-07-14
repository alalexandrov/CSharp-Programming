using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Sign
    {
        private string signName = "";
        private DateTime startDate = new DateTime();
        private DateTime endDate = new DateTime();

        public string Name
        {
            get
            {
                return this.signName;
            }
            private set
            {
                if (value != null || value.Length > 20)
                {
                    this.signName = value;  
                }
                else
                {
                    throw new ArgumentException("Invalid sign name !!!");
                }
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return this.endDate;
            }
        }

        public Sign(string Name, DateTime StartDate, DateTime EndDate)
        {
            this.Name = Name;
            this.startDate = StartDate;
            this.endDate = EndDate;
        }
    }
}
