using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;


namespace Task_1
{
    class BrowseDir
    {
        static void Main(string[] args)
        {
            try
            {
                //Menu
                string choice = "";
                string FolderPath = "";
                bool IsWrongChoice = false;
                do
                {

                    Console.WriteLine("Please select a directory");
                    Console.WriteLine("'1' for MyDocuments");
                    Console.WriteLine("'2' for MyPictures");
                    Console.WriteLine("'3' for MyMusic");
                    Console.WriteLine("'4' for Custom Directory");
                    Console.Write("Your Choice is: ");
                    choice = Console.ReadLine();
                    IsWrongChoice = false;
                    switch (choice)
                    {
                        case "1": FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); break;
                        case "2": FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); break;
                        case "3": FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); break;
                        case "4": Console.Write("Please enter Path: ");
                            FolderPath = Console.ReadLine();
                            while (!Directory.Exists(FolderPath))
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong Path or Path is NOT exist!");
                                Console.Write("Please enter again: ");
                                FolderPath = Console.ReadLine();
                            }
                            break;

                        default: Console.Clear();
                            Console.WriteLine("Wrong Choice Try Again !!!\n");
                            IsWrongChoice = true;
                            break;
                    }

                } while (IsWrongChoice);

                Console.Write("Please enter FileName for output file: ");
                string FileName = Console.ReadLine();
                Console.Clear();

                //Getting output (Directories and files on them)
                StringBuilder Output = new StringBuilder();
                Output.AppendLine("| Directories and Files |");
                Output.AppendLine(new string('-', 25));
                GetDirectoriesAndFiles(FolderPath, Output, "");


                //Printing output on console
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.WriteLine(Output + "\n");
                Console.WriteLine("The information is saved in your Desktop. \n");

                //Writing output on file                       
                string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamWriter wr = new StreamWriter(FilePath + "\\" + FileName + ".txt");
                using (wr)
                {
                    wr.Write(Output);
                }

            }
            catch (ArgumentException)
            {
                Console.Clear();
                Console.WriteLine("Error ! - Invalid input");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void GetDirectoriesAndFiles(string path, StringBuilder Output, string spacing)
        {

            //Writing current directory on file and Getting subdirs on current directory
            string[] dirs = Directory.GetDirectories(path);
            Output.AppendLine(spacing + "->" + path);

            //Getting file names without paths on current directory and writing them to file
            Output.AppendLine(spacing + " Files:");
            string[] FileNamesWithPaths = Directory.GetFiles(path);
            if (FileNamesWithPaths.Length != 0)
            {
                foreach (var item in FileNamesWithPaths)
                {
                    Output.AppendLine(spacing + " - " + Path.GetFileName(item));
                }
            }
            else
            {
                Output.AppendLine(spacing + "None");
            }

            Output.AppendLine();

            foreach (var dir in dirs)
            {
                GetDirectoriesAndFiles(dir, Output, spacing + "    ");
            }
        }
    }
}
