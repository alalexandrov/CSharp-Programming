using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IsGivenPointIsWithinCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int xCord = 4;
            int yCord = 3;
            int CircleRadius = 5;
            
            // checks if given point (x,  y) is within a circle K(O, 5).
            bool check = (xCord * xCord) + (yCord * yCord) <= (CircleRadius * CircleRadius);
            
            Console.WriteLine("Point with X = {0} and Y = {1}", xCord, yCord);
            Console.WriteLine("Is within a circle K(O, 5): {0}", check);
        }
    }
}
