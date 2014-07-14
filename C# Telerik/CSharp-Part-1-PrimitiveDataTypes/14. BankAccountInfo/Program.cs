using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BankAccountInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Pesho";
            string MiddleName = "Peshov";
            string LastName = "Peshov";
            decimal Money = 100000;
            string BankName = "DSK";
            string IBAN = "BG UBBS 9413 5555 3213 23";
            string BIC = "UBBS12";
            string CretitCardID1 = "1234 1234 1234 1234";
            string CretitCardID2 = "5678 5678 5678 5678";
            string CretitCardID3 = "2345 2345 2345 2345";

            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Middle name: {0}", MiddleName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("Money: {0}", Money);
            Console.WriteLine("Bank name: {0}", BankName);
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("BIC: {0}", BIC);
            Console.WriteLine("1. Credit cart ID: {0}", CretitCardID1);
            Console.WriteLine("2. Credit cart ID: {0}", CretitCardID2);
            Console.WriteLine("3. Credit cart ID: {0}", CretitCardID3);
        }
    }
}
