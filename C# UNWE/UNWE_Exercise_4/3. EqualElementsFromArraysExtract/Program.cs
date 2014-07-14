using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of first array: ");
            int FirstArrLenght = int.Parse(Console.ReadLine());
            int[] FirstArr = new int[FirstArrLenght];
            for (int i = 0; i < FirstArr.Length; i++)    
            {
                Console.Write("Enter element {0}: ",i + 1);
                FirstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter lenght of second array: ");
            int SecondArrLenght = int.Parse(Console.ReadLine());
            int[] SecondArr = new int[SecondArrLenght];

            for (int i = 0; i < SecondArr.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                SecondArr[i] = int.Parse(Console.ReadLine());
            }

            int [] ThirdArr = FirstArr.Intersect(SecondArr).ToArray<int>();

            if (ThirdArr.Length == 0)
            {
                Console.WriteLine("The arrays didn't have intersection !");
                return;
            }
            Console.WriteLine();
            Console.Write("The intersection of arrays is: ");
            Console.WriteLine(String.Join(",", ThirdArr));
            Console.Write("The MAX element of intersection is: ");
            Console.WriteLine(ThirdArr.Max());
           
        }
    }
}
