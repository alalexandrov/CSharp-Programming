using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class HumanSign
    {
        private string signName = "";
        private int startDay = 0;
        private int endDay = 0;
        private int startMonth = 0;
        private int endMonth = 0;

        public string SignName
        {
            get
            {
                return this.signName;
            }
            private set
            {
                if (value != null && value.Length < 22)
                {
                    this.signName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Human Sign Name !!!");
                }
            }
        }

        public int StartDay
        {
            get
            {
                return this.startDay;
            }
            set
            {
                if (value >= 1 || value <= 31)
                {
                    this.startDay = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Human Sign Start Day !!!");
                }
            }
        }

        public int EndDay
        {
            get
            {
                return this.endDay;
            }
            set
            {
                if (value >= 1 || value <= 31)
                {
                    this.endDay = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Human Sign End Day !!!");
                }
            }
        }

        public int StartMonth
        {
            get
            {
                return this.startMonth;
            }
            set
            {
                if (value >= 1 || value <= 12)
                {
                    this.startMonth = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Human Sign Start Month !!!");
                }
            }
        }

        public int EndMonth
        {
            get
            {
                return this.endMonth;
            }
            set
            {
                if (value >= 1 || value <= 12)
                {
                    this.endMonth = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Human Sign Start Month !!!");
                }
            }
        }

        public HumanSign(string Name, int StartDay, int StartMonth, int EndDay, int EndMonth)
        {
            this.SignName = Name;
            this.StartDay = StartDay;
            this.StartMonth = StartMonth;
            this.EndDay = EndDay;
            this.EndMonth = EndMonth;
        }

    }
}
