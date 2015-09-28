namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        private double width;
        private double height;
        private double radius;

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width cannot be a negative number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be a negative number!");
                }

                this.height = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius cannot be a negative number!");
                }

                this.radius = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
