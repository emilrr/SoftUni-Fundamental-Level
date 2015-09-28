using System;
using System.Collections.Generic;
using System.IO;
using _01.Point3D;

namespace _03.Paths
{
    class Path3DTest
    {
        static void Main()
        {
            try
            {
                Point3D point1 = new Point3D(1, 5, 24);
                Point3D point2 = new Point3D(0, -12, 3);
                Point3D point3 = new Point3D(1, 5, 3);
                Path3D path = new Path3D(point1, point2, point3);
                Console.WriteLine(path);
                Storage.SavePathToFile("../../path.txt", path.ToString());
                Console.WriteLine("Load from file:\n" + Storage.LoadPathFromFile("../../path.txt"));
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file!");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not open the file!");
            }
        }
    }
}
