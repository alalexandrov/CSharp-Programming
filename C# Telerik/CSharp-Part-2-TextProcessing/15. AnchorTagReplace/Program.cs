using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AnchorTagReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            //Replacing anchor tags with URL tags
            string startTag = "<a href=\"";
            string StartTagEnd = "\">";
            string endTag = "</a>";
            
            text = text.Replace(startTag, "[URL=");
            text = text.Replace(StartTagEnd, "]");
            text = text.Replace(endTag, "[/URL]");

            Console.WriteLine("The result is");
            Console.WriteLine(text);
        }
    }
}
