using _3.FirstNameBeforeLastNameStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortingStudentsByFirstAndLastName
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

            //Sort the students by first name and last name in descending order. 
            //With Lambda expression
            var sortedWithLambda = students.OrderBy(S => S.FirstName).ThenBy(S => S.LastName).Reverse();

            //With LINQ
            var sortedWithLINQ = from stud in students
                                 orderby stud.FirstName descending, stud.LastName descending
                                 select stud;

            //Printing result to Console
            foreach (var stud in sortedWithLambda)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine("----------------");

            foreach (var stud in sortedWithLINQ)
            {
                Console.WriteLine(stud);
            }
        }
    }
}
