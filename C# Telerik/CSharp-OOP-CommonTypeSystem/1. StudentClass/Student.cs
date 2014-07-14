using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentClass
{
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public int Course { get; set; }
        public Speciality Speciality { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
                return false;
            if (!Object.Equals(this.FirstName, student.FirstName))
                return false;
            if (!Object.Equals(this.MiddleName, student.MiddleName))
                return false;
            if (!Object.Equals(this.LastName, student.LastName))
                return false;
            if (!Object.Equals(this.SSN, student.SSN))
                return false;
            if (!Object.Equals(this.Address, student.Address))
                return false;
            if (!Object.Equals(this.MobilePhone, student.MobilePhone))
                return false;
            if (!Object.Equals(this.Course, student.Course))
                return false;
            if (!Object.Equals(this.Speciality, student.Speciality))
                return false;
            if (!Object.Equals(this.University, student.University))
                return false;
            if (!Object.Equals(this.Faculty, student.Faculty))
                return false;

            return true;
        }

        public override string ToString()
        {
            return string.Format(
                "First name: {0}\n" +
                "Middle name: {1}\n" +
                "Last name: {2}\n" +
                "SSN: {3}\n" +
                "Address: {4}\n" +
                "Mobile phone: {5}\n" +
                "Course: {6}\n" +
                "Speciality: {7}\n" +
                "University: {8}\n" +
                "Faculty: {9}",
                this.FirstName, this.MiddleName, this.LastName,
                this.SSN, this.Address, this.MobilePhone,
                this.Course, this.Speciality, this.University, this.Faculty);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.MobilePhone.GetHashCode();
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public object Clone()
        {
            return new Student()
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                SSN = this.SSN,
                Address = this.Address,
                MobilePhone = this.MobilePhone,
                Course = this.Course,
                Speciality = this.Speciality,
                University = this.University,
                Faculty = this.Faculty
            };
        }

        public int CompareTo(Student other)
        {
            if ((this.FirstName.CompareTo(other.FirstName) == -1) &&
                (this.SSN.CompareTo(other.SSN) == -1))
            {
                return 1;
            }
            else if ((this.FirstName.CompareTo(other.FirstName) == 0) &&
                   (this.SSN.CompareTo(other.SSN) == 0))
            {
                return 0;
            }
            else
            {
                return -1;
            }   
        }
    }
}
