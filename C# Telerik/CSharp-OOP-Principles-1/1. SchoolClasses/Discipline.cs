using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class Discipline : ICommentable
    {
        private string name;
        private int numOfLectures;
        private int numOfExercises;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && value.Length > 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid discipline name. Name must be at least 3 characters !");
                }
            }
        }
        public int NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }
            set
            {
                if (value > 0)
                {
                    this.numOfLectures = value;
                }
                else
                {
                    throw new ArgumentException("Invalid number of lectures !");
                }
            }
        }
        public int NumOfExercises
        {
            get
            {
                return this.numOfExercises;
            }
            set
            {
                if (value > 0)
                {
                    this.numOfExercises = value;
                }
                else
                {
                    throw new ArgumentException("Invalid number of exercises !");
                }
            }
        }

        public Discipline(string name, int numOfLectures, int numOfExercises)
        {
            this.Name = name;
            this.NumOfLectures = numOfLectures;
            this.NumOfExercises = numOfExercises;
        }

        public Discipline() { }

        public string Comment { get; set; }
    }
}
