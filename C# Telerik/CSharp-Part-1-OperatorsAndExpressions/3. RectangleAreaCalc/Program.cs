using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RectangleAreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            float Width = 5f;
            float Height = 5f;

            float RectangleArea = (Width * Height) / 2;
            Console.WriteLine("The rectangle area is: {0}", RectangleArea);
        }
    }
}
