﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WhichDayIsToday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The weekday of today is: {0}", DateTime.Now.DayOfWeek);
        }
    }
}