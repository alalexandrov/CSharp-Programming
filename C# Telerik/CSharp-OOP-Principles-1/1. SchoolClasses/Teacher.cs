using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class Teacher : Human, ICommentable
    {
        private Discipline[] disciplines;

        public Discipline[] Disciplines
        {
            get
            {
                return (Discipline[])this.disciplines.Clone();
            }
            set
            {
                if (value != null)
                {
                    this.disciplines = value;
                }
                else
                {
                    throw new ArgumentException("The value of disciplines can't be null !");
                }
            }
        }

        public Teacher(string name, Discipline[] disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher() { }

        public string Comment { get; set; }
    }
}
