using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            List<Student> students = new List<Student> { 
                new Student("Alex", "Alexandrov", 6),
                new Student("Pesho", "Peshov", 2),
                new Student("Georgi", "Georgiev", 5),
                new Student("Tosho", "Toshev", 3),
                new Student("Mariq", "Marieva", 2),
                new Student("Silvena", "Slavova", 4),
                new Student("Ivan", "Ivanov", 3),
                new Student("Petur", "Stoqnov", 6),
                new Student("Petko", "Parvanov", 5),
                new Student("Stefan", "Stambolov", 6),};

            //Order students by grade
            var orderedStudents = students.OrderBy(s => s.Grade);

            //Printing them to Console
            Console.WriteLine("***Ordered students***\n");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student + "\n");
            }

            List<Worker> workers = new List<Worker>() { 
                new Worker("Kiril","Kirilov",100,6),
                new Worker("Gosho","Ivanov",300,7),
                new Worker("Petur","Georgiev",200,4),
                new Worker("Gospodin","Tashev",500,7),
                new Worker("Raq","Kirilova",600,8),
                new Worker("Kameliq","Karaivanova",350,6),
                new Worker("Stoqn","Alexandrov",400,8),
                new Worker("Ivan","Vazov",1000,12),
                new Worker("Teodor","Stefanov",900,10),
                new Worker("Liubo","Lavov",850,8)};

            //Order workers by money per hour descending
            var orderedWorkers = from worker in workers
                                 orderby worker.MoneyPerHour() descending
                                 select worker;

            //Printing them to Console
            Console.WriteLine("***Ordered workers***\n");
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
                Console.WriteLine("Money/hour: {0}\n", worker.MoneyPerHour());
            }

            //Merge workers and students
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            //Sort humans by first and last name
            var sortedHumans = from human in humans
                               orderby human.FirstName, human.LastName
                               select human;

            //Printing them to console
            Console.WriteLine("***Ordered humans***\n");
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human + "\n");
            }
        }
    }
}
