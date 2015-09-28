using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);
        private double pointX;
        private double pointY;
        private double pointZ;
        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return this.pointX; }
            set { this.pointX = value; }
        }

        public double Y
        {
            get { return this.pointY; }
            set { this.pointY = value; }
        }

        public double Z
        {
            get { return this.pointZ; }
            set { this.pointZ = value; }
        }

        public override string ToString()
        {
            StringBuilder strPoints = new StringBuilder();
            strPoints.AppendLine("X = " + this.X);
            strPoints.AppendLine("Y = " + this.Y);
            strPoints.AppendLine("Z = " + this.Z);
            return strPoints.ToString();
        }
    }


}
