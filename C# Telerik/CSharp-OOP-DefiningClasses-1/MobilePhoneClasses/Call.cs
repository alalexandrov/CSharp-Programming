using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClasses
{
    class Call
    {
        private DateTime date = DateTime.Now;
        private string phoneNum;
        private int durationInSec;

        //Properties
        public string PhoneNumber
        {
            get
            {
                return this.phoneNum;
            }
        }
        public int DurationInSec
        {
            get
            {
                return this.durationInSec;
            }
        }

        //Constructor
        public Call(string phoneNum, int durationInSec)
        {
            this.phoneNum = phoneNum;
            this.durationInSec = durationInSec;
        }

        //Override ToString
        public override string ToString()
        {
            return string.Format("Performed at: {0}\nDialed number: {1}\nDuration: {2} sec.\n", this.date, this.phoneNum, this.durationInSec);
        }
    }
}
