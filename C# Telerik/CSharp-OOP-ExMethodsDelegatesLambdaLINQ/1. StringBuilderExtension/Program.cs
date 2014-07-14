using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilderExtension
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder substring = new StringBuilder();
            substring.Append(sb.ToString().Substring(index, length));
            return substring;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test StringBuilder Substring extension method 
            StringBuilder text = new StringBuilder();
            text.Append("This is test for extension method !");

            StringBuilder substr = text.Substring(8, 4);
            Console.WriteLine(substr);
        }
    }
}
