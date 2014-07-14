using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WorkingWith3DCordinates
{
    class _3DPointDistanceCalculator
    {
        public static double CalcDiscance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt(Math.Pow(first.CordX - second.CordX, 2) +
                Math.Pow(first.CordY - second.CordY, 2) +
                Math.Pow(first.CordZ - second.CordZ, 2));

            return Math.Round(distance, 2);
        }
    }
}
