using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNWE_Exercise_3
{
    class Task
    {
        protected string TaskName = "";

        public virtual void ExecuteTask()
        {
        }

        protected void ShowResult(string result)
        {
            Console.WriteLine();
            Console.WriteLine(this.TaskName);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(result);
            Console.WriteLine(new string('-', 60));

        }
    }
}
