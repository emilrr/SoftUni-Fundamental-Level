namespace CohesionAndCoupling.Utils
{
    using System;

    public static class Calculate2D
    {
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static double Diagonal(double width, double height)
        {
            double diagonal = Distance(0, 0, width, height);
            return diagonal;
        }
    }
}