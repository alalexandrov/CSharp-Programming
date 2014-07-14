using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WorkingWith3DCordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            //Creating some points
            Point3D[] points = { new Point3D(1, 2, 3), new Point3D(1, 1, 3), new Point3D(0, 2, 3),
            new Point3D(4,2,3), new Point3D(3,2,5), new Point3D(9,0,1), new Point3D(7,2,4)};

            //Creating path of points
            Path PointPath = new Path(points);

            //Saving paths to text file
            PathStorage.SavePaths(new Path[] { PointPath });

            //Loading paths from text file
            Path[] paths = PathStorage.LoadPaths();

            //Printing all points in paths to Console
            foreach (var path in paths)
            {
                foreach (var point in path.Points)
                {
                   Console.WriteLine(point);
                }
                Console.WriteLine();
            }
        }
    }
}
