using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.IsGivenPointIsWithinCircleAndOutOfRect
{
    class Program
    {
        static void Main(string[] args)
        {
            int xCord = 1;
            int yCord = 3;

            int circleRadius = 3;

            //checks for given point (x, y) if it is within the circle K( (1,1), 3) 
            //and out of the rectangle R(top=1, left=-1, width=6, height=2).

            bool circleCheck = (xCord - 1) * (xCord - 1) + (yCord - 1) * (yCord - 1) <= circleRadius * circleRadius;
            bool rectangleCheck = xCord < -1 || yCord > 1 || yCord < -1;
            bool CheckResult = circleCheck && rectangleCheck;
            Console.WriteLine("The point ({0}, {1}) is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2) ? :", xCord, yCord);
            Console.WriteLine(CheckResult);


        }
    }
}
