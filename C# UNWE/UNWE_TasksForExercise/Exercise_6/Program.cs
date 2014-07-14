using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            HumanSign Oven = new HumanSign("Oven", 21, 3, 20, 4);
            HumanSign Telec = new HumanSign("Telec", 21, 4, 21, 5);
            HumanSign Bliznaci = new HumanSign("Bliznaci", 22, 5, 21, 6);
            HumanSign Rak = new HumanSign("Rak", 22, 6, 23, 7);
            HumanSign Luv = new HumanSign("Luv", 24, 7, 23, 8);
            HumanSign Deva = new HumanSign("Deva", 24, 8, 23, 9);
            HumanSign Vezni = new HumanSign("Vezni", 24, 9, 23, 10);
            HumanSign Skorpion = new HumanSign("Skorpion", 24, 10, 22, 11);
            HumanSign Strelec = new HumanSign("Strelec", 23, 11, 22, 12);
            HumanSign Kozirog = new HumanSign("Kozirog", 23, 12, 20, 1);
            HumanSign Vodolei = new HumanSign("Vodolei", 21, 1, 19, 2);
            HumanSign Ribi = new HumanSign("Ribi", 20, 2, 20, 3);

            var HumanSigns = new [] { Oven, Telec, Bliznaci, Rak, Luv, Deva, Vezni, Skorpion, Strelec, Kozirog, Vodolei, Ribi };
            foreach (var item in HumanSigns)
            {
                Console.WriteLine(item.SignName);
                Console.WriteLine("{0}.{1} - {2}.{3}",item.StartDay,item.StartMonth,item.EndDay,item.EndMonth);
                Console.WriteLine();
            }
            

        }
    }
}
