using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Triangle(3,5),
                              new Rectangle(3,5),
                              new Circle(3)};

            foreach (var shape in shapes)
            {
                Console.WriteLine("The {0} surface is: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
