namespace CohesionAndCoupling.Utils
{
    using System;

    public static class Calculate3D
    {
        public static double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }

        public static double Volume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double DiagonalXyz(double width, double height, double depth)
        {
            double diagonalXyz = Distance(0, 0, 0, width, height, depth);
            return diagonalXyz;
        }

        public static double DiagonalXy(double width, double height)
        {
            double diagonalXy = Calculate2D.Diagonal(width, height);
            return diagonalXy;
        }

        public static double DiagonalXz(double width, double depth)
        {
            double diagonalXz = Calculate2D.Diagonal(width, depth);
            return diagonalXz;
        }

        public static double DiagonalYz(double height, double depth)
        {
            double diagonalYz = Calculate2D.Diagonal(height, depth);
            return diagonalYz;
        }
    }
}