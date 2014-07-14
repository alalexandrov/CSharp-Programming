using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesClasses
{
    class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height) : base(width, height) { }

        public override decimal CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
