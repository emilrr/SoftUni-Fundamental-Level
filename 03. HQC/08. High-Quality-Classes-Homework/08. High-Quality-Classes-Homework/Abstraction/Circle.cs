namespace Abstraction
{
    using System;

    internal class Circle : Figure
    {
        public Circle(double radius)
            : base(radius)
        {
            this.Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateArea()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
