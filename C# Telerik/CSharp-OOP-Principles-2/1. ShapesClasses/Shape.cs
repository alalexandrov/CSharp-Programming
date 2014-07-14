using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesClasses
{
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " width !");
                }
            }
        }
        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Invalid " + this.GetType().Name + " height !");
                }
            }
        }

        protected Shape(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract decimal CalculateSurface();
    }
}
