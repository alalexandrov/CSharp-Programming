using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            Student[] Students = {new Student{Name = "Alex", FacultyNumber="119988"},
                                  new Student{Name = "Katq", FacultyNumber="119955"},
                                  new Student{Name = "Pesho", FacultyNumber="117788"}};

            Discipline[] Disciplines = {new Discipline("Web Design",4,6),
                                        new Discipline("Computer programming",5,9),
                                        new Discipline("Arhitectures",6,7)};

            Teacher[] Teachers = {new Teacher{Name = "Stoqn", Disciplines = Disciplines},
                                 new Teacher{Name = "Ivan",Disciplines = Disciplines}};

            StudentsClass[] StudentClasses = {new StudentsClass { ClassID = 'A', Students = Students, Teachers = Teachers },
                                              new StudentsClass { ClassID = 'B', Students = Students, Teachers = Teachers }};

            ICommentable[] comments = {new Student { Name = "Alex", FacultyNumber = "119988", Comment = "Rullz" }, 
                                       new Discipline{Name = "Computer programming",NumOfLectures = 5 ,NumOfExercises = 9, Comment = "Best"},
                                       new Teacher{Name = "Stoqn", Disciplines = Disciplines, Comment = "justice"},
                                       new StudentsClass { ClassID = 'A', Students = Students, Teachers = Teachers, Comment = "RullZzz" }};

            School school = new School() { Classes = StudentClasses };
        }
    }
}
