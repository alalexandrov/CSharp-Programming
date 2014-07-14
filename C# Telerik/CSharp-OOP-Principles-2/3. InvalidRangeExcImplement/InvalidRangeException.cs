using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InvalidRangeExcImplement
{
    class InvalidRangeException<T> : Exception
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception causeExc = null)
            : base(message, causeExc)
        {
            this.start = start;
            this.end = end;
        }

        public override string Message
        {
            get
            {
                return string.Format("{0} Value must be in range:[{1}... {2}]", base.Message, this.start, this.end);
            }
        }
    }
}
