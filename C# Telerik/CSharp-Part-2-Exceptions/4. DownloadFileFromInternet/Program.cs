using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _4.DownloadFileFromInternet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File downloader\n");
            Console.Write("Please enter File URL: ");
            string remoteUri = Console.ReadLine();

            //Get file name and path of Desktop
            string FileName = Path.GetFileName(remoteUri);
            string DestinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            WebClient wc = new WebClient();

            //Try to download file
            try
            {
                wc.DownloadFile(remoteUri, DestinationPath + "\\" + FileName);
                Console.WriteLine("\nSuccessfully Downloaded File !");
                Console.WriteLine("\nFile is saved on your desktop\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid URL !", ex);
            }
            finally
            {
                wc.Dispose();
            }      
        }
    }
}
