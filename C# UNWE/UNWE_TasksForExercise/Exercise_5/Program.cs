using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {       
                //Menu
                string DirectoryPath = "";
                do
                {
                    Console.WriteLine("Please enter valid directory path: ");
                    DirectoryPath = Console.ReadLine();
                } while (!Directory.Exists(DirectoryPath));

                string PathToSave = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamWriter wr = new StreamWriter(PathToSave + "\\Files.txt");
                wr.WriteLine("Files in {0}", DirectoryPath);
                wr.WriteLine();

                // Getting files from directory and write them to file by Modification Date
                List<string> Files = Directory.GetFiles(DirectoryPath).ToList();

                DateTime MaxModificationDate = DateTime.MinValue;
                string FileWithMaxDate = "";
                while (Files.Count != 0)
                {
                    for (int i = 0; i < Files.Count; i++)
                    {
                        //Getting file with max modification date
                        if (File.GetLastWriteTime(Files[i]) > MaxModificationDate)
                        {
                            MaxModificationDate = File.GetLastWriteTime(Files[i]);
                            FileWithMaxDate = Files[i];
                        }
                    }

                    wr.WriteLine("{0} ", Path.GetFileName(FileWithMaxDate));
                    wr.WriteLine(" -Last Modificaton Time: {0}", File.GetLastWriteTime(FileWithMaxDate));
                    wr.WriteLine();
                    Files.Remove(FileWithMaxDate);
                    MaxModificationDate = DateTime.MinValue;
                }
                wr.Close();
                Console.Clear();
                Console.WriteLine("Files are save on your Desktop in Files.txt");
        }
    }
}
