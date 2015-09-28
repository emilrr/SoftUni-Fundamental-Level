using System;
using System.Collections.Generic;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class PointsTest
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1, 5, 24);
            Point3D point2 = new Point3D(0, -12, 3);

            Console.WriteLine(DistanceCalculator.CalculateDistance(point1, point2));
        }
    }
}
