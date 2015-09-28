using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle : BasicShape
    {
        private double thirdSide;
        public Triangle(double width, double height, double thirdSide)
            : base(width, height)
        {
            this.ThirdSide = thirdSide;

            if (!TriangleIsValid(this.Width, this.Height, this.ThirdSide))
            {
                throw new ArgumentException("These three sides can not form a triangle.");
            }
        }

        public double ThirdSide
        {
            get { return this.thirdSide; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("thirdSide", "The third side cannot be a negative number!");
                }
                this.thirdSide = value;
            }
        }
        public override double CalculateArea()
        {
            double p = (this.Width + this.Height + this.ThirdSide) / 2;
            double resultArea = Math.Sqrt(p * (p - this.Width) * (p - this.Height) * (p - this.ThirdSide));

            return resultArea;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width + this.Height + this.ThirdSide;

            return perimeter;
        }
        private bool TriangleIsValid(double Width, double Height, double ThirdSide)
        {
            return Width + Height > ThirdSide && Height + ThirdSide > Width && Width + ThirdSide > Height;
        }
    }
}
