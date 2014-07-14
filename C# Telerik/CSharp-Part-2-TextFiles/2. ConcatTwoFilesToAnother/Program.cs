using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConcatTwoFilesToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading first and second file and writing to another 
            try
            {
                StreamReader FirstFileReader = new StreamReader("..\\..\\Text.txt");
                StreamReader SecondFileReader = new StreamReader("..\\..\\Text2.txt");
                StreamWriter writer = new StreamWriter("..\\..\\Result.txt", true);

                using (writer)
                {

                    using (FirstFileReader)
                    {
                        writer.WriteLine(FirstFileReader.ReadToEnd());
                    }

                    writer.WriteLine(new string('-', 50));

                    using (SecondFileReader)
                    {
                        writer.WriteLine(SecondFileReader.ReadToEnd());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("The files concatenates successfully. The result is in Result.txt");
        }
    }
}
