using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ComparingTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader FirstFileReader = new StreamReader("..\\..\\Text.txt");
                StreamReader SecondFileReader = new StreamReader("..\\..\\Text2.txt");

                int DifferentLineCount = 0;
                int SameLineCount = 0;

                //Reading files line by line and comparing them
                using (FirstFileReader)
                {
                    using (SecondFileReader)
                    {
                        string FirstFileCurLine = FirstFileReader.ReadLine();
                        string SecondFileCurLine = SecondFileReader.ReadLine();

                        while (FirstFileCurLine != null && SecondFileCurLine != null)
                        {
                            if (FirstFileCurLine.CompareTo(SecondFileCurLine) == 0)
                            {
                                SameLineCount++;
                            }
                            else
                            {
                                DifferentLineCount++;
                            }

                            FirstFileCurLine = FirstFileReader.ReadLine();
                            SecondFileCurLine = SecondFileReader.ReadLine();
                        }
                    }
                }

                Console.WriteLine("Comparing files result");
                Console.WriteLine("The number of equal lines is: {0}", SameLineCount);
                Console.WriteLine("The number of different lines is: {0}", DifferentLineCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
