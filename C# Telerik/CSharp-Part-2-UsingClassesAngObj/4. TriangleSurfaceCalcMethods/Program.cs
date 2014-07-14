using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TriangleSurfaceCalcMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = 3;
            int side2 = 5;
            int side3 = 6;
            int height = 2;
            int angle = 60;

            Console.WriteLine("The surface by given side and height: {0}", CalcTriangleSurface(side1, height));
            Console.WriteLine("The surface by given three sides: {0}", CalcTriangleSurface(side1, side2, side3));
            Console.WriteLine("The surface by given two sides angle between them: {0}", CalcTriangleSurface(side1, side2, angle));
        }

        public static double CalcTriangleSurface(double side, double height)
        {
            return (side * height) / 2;
        }

        public static double CalcTriangleSurface(double side1, double side2, double side3)
        {
            double HalfPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(HalfPerimeter * 
                (HalfPerimeter - side1) * 
                (HalfPerimeter * side2) * 
                (HalfPerimeter * side3));
        }

        public static double CalcTriangleSurface(double side1, double side2, int angle)
        {
            double angleInDegrees = Math.PI * angle / 180;
            return side1 * side2 * Math.Sin(angleInDegrees);
        }
    }
}
