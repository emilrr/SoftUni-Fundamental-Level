namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Utils;

    public static class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(File.GetExtension("example"));
            Console.WriteLine(File.GetExtension("example.pdf"));
            Console.WriteLine(File.GetExtension("example.new.pdf"));

            Console.WriteLine(File.GetNameWithoutExtension("example"));
            Console.WriteLine(File.GetNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Calculate2D.Distance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Calculate3D.Distance(5, 2, -1, 3, -6, 4));

            double width = 3;
            double height = 4;
            double depth = 5;
            Console.WriteLine("Volume = {0:f2}", Calculate3D.Volume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Calculate3D.DiagonalXyz(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Calculate3D.DiagonalXy(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Calculate3D.DiagonalXz(width, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Calculate3D.DiagonalYz(height, depth));
        }
    }
}
