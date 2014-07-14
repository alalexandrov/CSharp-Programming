using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TwoNumComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            int NumX = int.Parse(Console.ReadLine());

            Console.Write("Enter Y: ");
            int NumY = int.Parse(Console.ReadLine());

            int greaterNum = (NumX + NumY + Math.Abs(NumX - NumY)) / 2;
            Console.WriteLine("Greater num is: {0}", greaterNum);
        }
    }
}
