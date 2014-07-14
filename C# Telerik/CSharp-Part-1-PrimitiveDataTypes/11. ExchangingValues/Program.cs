using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExchangingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int varX = 5;
            int varY = 10;

            Console.WriteLine("Values: X: {0} Y: {1}", varX, varY);

            int temp = 0;
            temp = varX;
            varX = varY;
            varY = temp;

            Console.WriteLine("Exchanged Values: X: {0} Y: {1}", varX, varY);


        }
    }
}
