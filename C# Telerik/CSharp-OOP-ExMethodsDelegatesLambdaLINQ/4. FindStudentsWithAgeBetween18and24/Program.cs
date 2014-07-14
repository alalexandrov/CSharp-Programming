using _3.FirstNameBeforeLastNameStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindStudentsWithAgeBetween18and24
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[] {
                new Student{FirstName = "Alexander", LastName = "Alexandrov", Age = 18},
                new Student{FirstName = "Pesho", LastName = "Vladimirov", Age = 24},
                new Student{FirstName = "Todor", LastName = "Ivanov", Age = 19},
                new Student{FirstName = "Zelko", LastName = "Stoqnov", Age = 32},
                new Student{FirstName = "Ivan", LastName = "Parvanov", Age = 25},
                new Student{FirstName = "Vlado", LastName = "Karaivanov", Age = 21}        
            };

            //Findind student with age between 18 and 24
            var StudWithAge = from stud in students
                              where stud.Age >= 18 && stud.Age <= 24
                              select stud;

            //Printing them to console
            foreach (var stud in StudWithAge)
            {
                Console.WriteLine(stud);
            }
        }
    }
}
