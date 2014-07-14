using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesClasses
{
    class Circle : Shape
    {
        public Circle(decimal radius) : base(radius * 2, radius * 2) { }
        public override decimal CalculateSurface()
        {
            return (decimal)Math.PI * (this.Height / 2) * (this.Height / 2);
        }
    }
}
