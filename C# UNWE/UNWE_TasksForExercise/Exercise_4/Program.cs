using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Comparing two text files");
                Console.WriteLine("There location is: Desktop\n");
                Console.Write("Please enter name of first file: ");
                string FirstFileName = Console.ReadLine();
                Console.Write("Please enter name of second file: ");
                string SecondFileName = Console.ReadLine();

                //Open streams for reading files and writing result on other file
                string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamReader ReadFirstFile = new StreamReader(FilePath + "\\" + FirstFileName + ".txt");
                StreamReader ReadSecondFile = new StreamReader(FilePath + "\\" + SecondFileName + ".txt");
                StreamWriter WriteResult = new StreamWriter(FilePath + "\\" + "Result.txt");

                // Reading and comparing files line by line 
                string FirstFileLine = ReadFirstFile.ReadLine();
                string SecondFileLine = ReadSecondFile.ReadLine();
                int LineNumber = 1;
                bool IsSame = true;
                while (FirstFileLine != null || SecondFileLine != null)
                {
                    if (!FirstFileLine.Equals(SecondFileLine))
                    {
                        IsSame = false;
                        WriteResult.WriteLine("There are a difference on line: {0}", LineNumber);
                        WriteResult.Write("{0}.txt line text: ", FirstFileName);
                        if (FirstFileLine == null)
                        {
                            WriteResult.WriteLine("#No TEXT");
                        }
                        else
                        {
                            WriteResult.WriteLine(FirstFileLine);
                        }

                        WriteResult.Write("{0}.txt line text: ", SecondFileName);
                        if (SecondFileLine == null)
                        {
                            WriteResult.WriteLine("#No TEXT");
                        }
                        else
                        {
                            WriteResult.WriteLine(SecondFileLine);
                        }
                        WriteResult.WriteLine();
                    }

                    FirstFileLine = ReadFirstFile.ReadLine();
                    SecondFileLine = ReadSecondFile.ReadLine();
                    LineNumber++;
                }

                if (IsSame)
                {
                    WriteResult.WriteLine("Files are same !");
                }

                Console.WriteLine("The file Result.txt is save to your Desktop !");
                WriteResult.Close();
                ReadFirstFile.Close();
                ReadSecondFile.Close();
            }

            catch(Exception f)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error !!!");
                Console.WriteLine(f.Message);
            }
        }
    }
}
