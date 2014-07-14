using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullValueToIntAndDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int? var1 = 1;
            Console.WriteLine(var1);
            var1 = null;
            Console.WriteLine(var1);

            double? var2 = 1;
            Console.WriteLine(var2);
            var2 = null;
            Console.WriteLine(var2);


        }
    }
}
