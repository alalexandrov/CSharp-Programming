using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.EncoderAndDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Nakov";
            string cipher = "ab";

            Console.WriteLine("Input string: {0}", input);
            Console.WriteLine("Encryption key: {0}", cipher);

            //Encode string with cipher
            string excripted = EncodeString(input, cipher);
            Console.WriteLine("Encoded string is: {0}", excripted);

            //Decode string with same cipher
            Console.WriteLine("Decoded string is {0}", DecodeString(excripted, cipher));

        }

        public static string EncodeString(string key, string cipter)
        {
            int CipterIndex = 0;
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < key.Length; i++)
            {
                output.Append((char)(key[i] ^ cipter[CipterIndex]));
                CipterIndex++;
                if (CipterIndex == cipter.Length)
                {
                    CipterIndex = 0;
                }
            }

            return output.ToString();
        }

        public static string DecodeString(string input, string cipter)
        {
            int CipterIndex = 0;
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                output.Append((char)(input[i] ^ cipter[CipterIndex]));
                CipterIndex++;
                if (CipterIndex == cipter.Length)
                {
                    CipterIndex = 0;
                }
            }

            return output.ToString();
        }
    }
}
