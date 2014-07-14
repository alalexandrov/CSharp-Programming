using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WorkingWith3DCordinates
{
    class PathStorage
    {
        public static void SavePaths(Path[] paths)
        {
            StreamWriter writer = new StreamWriter(@"..\..\PathStorage/Paths.txt", true);

            using (writer)
            {
                foreach (var path in paths)
                {
                    foreach (var point in path.Points)
                    {
                        writer.WriteLine(point);
                    }
                    writer.WriteLine("END");
                }
            }
        }

        public static Path[] LoadPaths()
        {
            StreamReader reader = new StreamReader(@"..\..\PathStorage/Paths.txt", true);

            List<Path> paths = new List<Path>();
            List<Point3D> points = new List<Point3D>();

            string line = reader.ReadLine();
            char[] characters = { ',', ' ', '(', ')' };
            while (line != null)
            {
                if (line != "END")
                {
                    string[] cords = line.Split(characters, StringSplitOptions.RemoveEmptyEntries);
                    Point3D CurrentPoint = new Point3D(int.Parse(cords[1]), int.Parse(cords[2]), int.Parse(cords[3]));
                    points.Add(CurrentPoint);
                }
                else
                {
                    Path CurrentPath = new Path(points.ToArray());
                    paths.Add(CurrentPath);
                    points.Clear();
                }

                line = reader.ReadLine();
            }

            return (Path[])paths.ToArray().Clone();
        }
    }
}
