using System;
using System.Collections.Generic;

namespace _01.Point3D
{
    class Point3DTest
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 12, 5.55);

            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
