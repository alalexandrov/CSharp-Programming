using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] borrowerData = new string[] { "Full name", "Gender", "Age", "Address", "Work Address", "Month income" };
            string[] creditData = new string[] {"Monthly interest", "Period", "Value", "Monthly payment", "Overdue interest", "APR"};
            
            StringBuilder Output = new StringBuilder();
            DateTime DateTimeNow = DateTime.Now;
            int count = 1;

            Output.AppendLine(DateTimeNow.ToLongDateString());
            Output.AppendLine(DateTimeNow.ToLongTimeString());
            Output.AppendLine();
            Output.AppendLine(string.Format("Personal data for Borrower {0}", count));
            Output.AppendLine();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter person data for Borrower {0}", count);
                Console.WriteLine();
       
                for (int i = 0; i < borrowerData.Length; i++)
                {
                    Console.Write(borrowerData[i] + " : ");
                    Output.AppendLine(borrowerData[i] + " : " + Console.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine("Enter credit data.");
                Console.WriteLine();

                Output.AppendLine();
                Output.AppendLine("His credit data:");
                Output.AppendLine();

                for (int i = 0; i < creditData.Length; i++)
                {
                    Console.Write(creditData[i] + " : ");
                    Output.AppendLine(creditData[i] + " : " + Console.ReadLine());
                }

                Output.AppendLine();
                string FileToSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamWriter sr = new StreamWriter(FileToSavePath + "\\" + "CreditRegister.txt",true);

                using (sr)
                {
                    sr.WriteLine(Output);
                    Output.Clear();
                }

                Console.Clear();
                
                Console.WriteLine("For Adding data on other Borrower write '1' and press Enter ");
                if (Console.ReadLine() != "1")
                {
                    Console.Clear();
                    Console.WriteLine("Good bye! ");
                    break;
                }
                
                count++;
            }

        }
    }
}
