using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.UrlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";

            //Extracting protocol
            string protocol = "none";
            int pEndIndex = url.IndexOf("//");

            if (pEndIndex != -1)
            {
                protocol = url.Substring(0, pEndIndex - 1);
                pEndIndex += 2;
            }
            else
            {
                pEndIndex = 0;
            }

            //Extracting server and source
            string server = "none";
            string source = "none";
            int SourceStartIndex = url.IndexOf("/", pEndIndex);

            if (SourceStartIndex != -1)
            {
                server = url.Substring(pEndIndex, SourceStartIndex - pEndIndex);
                source = url.Substring(SourceStartIndex);
            }
            else if (pEndIndex != url.Length)
            {
                server = url.Substring(pEndIndex);  
            }

            //Printing result to console
            Console.WriteLine("Protocol: {0}",protocol);
            Console.WriteLine("Server: {0}",server);
            Console.WriteLine("Source: {0}",source);
        }
    }
}
