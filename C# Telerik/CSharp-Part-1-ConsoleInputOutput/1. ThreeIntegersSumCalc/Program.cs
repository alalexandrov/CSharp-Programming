using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ThreeIntegersSumCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num x: ");
            int NumX = int.Parse(Console.ReadLine());

            Console.Write("Enter num y: ");
            int NumY = int.Parse(Console.ReadLine());

            Console.Write("Enter num z: ");
            int NumZ = int.Parse(Console.ReadLine());

            int sum = NumX + NumY + NumZ;

            Console.WriteLine("The sum of a numbers is: {0}", sum);
        }
    }
}
