using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WorkingWith3DCordinates
{
    struct Point3D
    {
        public int CordX { get; set; }
        public int CordY { get; set; }
        public int CordZ { get; set; }

        private static readonly Point3D Start = new Point3D(0, 0, 0);

        public static Point3D StartPoint
        {
            get
            {
                return Start;
            }
        }

        public Point3D(int cordX, int CordY, int CordZ)
            : this()
        {
            this.CordX = cordX;
            this.CordY = CordY;
            this.CordZ = CordZ;
        }

        public override string ToString()
        {
            return string.Format("Point: ({0}, {1}, {2})", this.CordX, this.CordY, this.CordZ);
        }
    }
}
