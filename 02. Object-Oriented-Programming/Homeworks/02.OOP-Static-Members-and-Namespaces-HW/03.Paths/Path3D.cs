using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01.Point3D;

namespace _03.Paths
{
    class Path3D
    {
        private readonly List<Point3D> path3D = new List<Point3D>();

        public Path3D(params Point3D[] list)
        {
            this.AddPoint(list);
        }

        public List<Point3D> Path
        {
            get { return this.path3D; }
            
        }

        public void AddPoint(params Point3D[] list)
        {
            foreach (var point in list)
            {
                this.path3D.Add(point);
            }
        }

        public override string ToString()
        {
            StringBuilder strResult = new StringBuilder();
            for (int i = 0; i < this.Path.Count; i++)
            {
                strResult.AppendFormat("point{0}: x={1} y={2} z={3}\n",
                    i + 1, this.Path[i].X, this.Path[i].Y, this.Path[i].Z);
            }
            return strResult.ToString();
        }
    }
}
