using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class StudentsClass : ICommentable
    {
        private char classID;
        private Student[] students;
        private Teacher[] teachers;

        public char ClassID
        {
            get
            {
                return this.classID;
            }
            set
            {
                if (char.IsLetter(value))
                {
                    this.classID = value;
                }
                else
                {
                    throw new ArgumentException("Invalid class identifier. Must be letter [A-Z] !");
                }
            }
        }
        public Student[] Students
        {
            get
            {
                return (Student[])this.students.Clone();
            }
            set
            {
                if (value != null)
                {
                    this.students = value;
                }
                else
                {
                    throw new ArgumentException("The value of students can't be null !");
                }
            }
        }
        public Teacher[] Teachers
        {
            get
            {
                return (Teacher[])this.teachers.Clone();
            }
            set
            {
                if (value != null)
                {
                    this.teachers = value;
                }
                else
                {
                    throw new ArgumentException("The value of teachers can't be null !");
                }
            }
        }

        public string Comment { get; set; }
    }
}
