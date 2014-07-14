using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WorkingWith3DCordinates
{
    class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public Point3D[] Points
        {
            get
            {
                return (Point3D[])this.points.ToArray().Clone();
            }
            set
            {
                if (value != null)
                {
                    foreach (var point in value)
                    {
                        this.points.Add(point);
                    }
                }
                else
                {
                    throw new ArgumentException("The points array can't be null !");
                }
            }
        }
        public Path(Point3D[] points)
        {
            this.Points = points;
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public void ClearPath()
        {
            this.points.Clear();
        }
    }
}
