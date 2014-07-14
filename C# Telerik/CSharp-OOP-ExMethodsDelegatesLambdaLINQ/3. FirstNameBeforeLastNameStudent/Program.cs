using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirstNameBeforeLastNameStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[] {
                new Student{FirstName = "Alexander", LastName = "Alexandrov", Age =22},
                new Student{FirstName = "Pesho", LastName = "Vladimirov", Age = 24},
                new Student{FirstName = "Todor", LastName = "Ivanov", Age = 21},
                new Student{FirstName = "Zelko", LastName = "Stoqnov", Age = 32},
                new Student{FirstName = "Ivan", LastName = "Parvanov", Age = 25},
                new Student{FirstName = "Vlado", LastName = "Karaivanov", Age = 21}        
            };

            //Get students whose first name is before last name alphabetically.
            var NewStudents = GetStudNames(students);

            //Printing them to console
            foreach (var student in NewStudents)
            {
                Console.WriteLine(student);
            }
        }

        public static IEnumerable<Student> GetStudNames(Student[] students)
        {
            var arr = from stud in students
                      where stud.FirstName.CompareTo(stud.LastName) == -1
                      select stud;

            return arr;
        }
    }
}
