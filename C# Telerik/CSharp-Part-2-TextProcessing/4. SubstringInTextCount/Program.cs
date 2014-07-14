using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SubstringInTextCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            //Printing occurences of substring 'in' in text
            Console.WriteLine("The substring 'in' in this text: \n");
            Console.WriteLine(text + "\n");
            Console.WriteLine("is: {0}", GetSubstringCount(text, "in"));
        }

        public static int GetSubstringCount(string text, string substring)
        {
            string TextLower = text.ToLower();
            string SubstrLower = substring.ToLower();
            int StartIndex = TextLower.IndexOf(SubstrLower);
            int count = 0;

            while (StartIndex != -1)
            {
                count++;
                StartIndex = TextLower.IndexOf(SubstrLower, StartIndex + 1);
            }

            return count;
        }
    }
}
