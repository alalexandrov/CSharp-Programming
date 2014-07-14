using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintingASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
