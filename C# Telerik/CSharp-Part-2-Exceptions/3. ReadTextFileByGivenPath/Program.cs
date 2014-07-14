using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReadTextFileByGivenPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter file path: ");
            string filePath = Console.ReadLine();
            string fileText = "";

            //Read file text
            try
            {
                fileText = File.ReadAllText(filePath);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Invalid file path !", ae);
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("File not found !", fnf);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Clear();
            Console.WriteLine("File text:\n\n");
            Console.WriteLine(fileText);
        }
    }
}
