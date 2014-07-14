using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReplacingSubstringsInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Text3Small.txt");
                StreamWriter writer = new StreamWriter("..\\..\\Result.txt");

                using (writer)
                {
                    using (reader)
                    {
                        //Reading file line by line and replacing substring "start" with "finish"
                        string CurrentLine = reader.ReadLine();
                        while (CurrentLine != null)
                        {
                            CurrentLine = CurrentLine.Replace("start", "finish");
                            writer.WriteLine(CurrentLine);
                            CurrentLine = reader.ReadLine();
                        }
                    }
                }

                Console.WriteLine("The result is saved at Result.txt");   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
}
