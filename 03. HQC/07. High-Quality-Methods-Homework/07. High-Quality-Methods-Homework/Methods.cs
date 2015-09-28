﻿namespace Methods
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine(CalculateTriangleArea(3, 4, 5));

                Console.WriteLine(ConvertIntNumberToStringDigit(5));

                Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

                PrintAsNumber(1.3, "f");
                PrintAsNumber(0.75, "%");
                PrintAsNumber(2.30, "r");

                bool horizontal, vertical;

                Console.WriteLine(CalculateDistanceBetweenTwoPoints(3, -1, 3, 2.5, out horizontal, out vertical));
                Console.WriteLine("Horizontal? " + horizontal);
                Console.WriteLine("Vertical? " + vertical);

                Student peter = new Student()
                {
                    FirstName = "Peter",
                    LastName = "Ivanov"
                };
                peter.OtherInfo = "From Sofia, born at 17.03.1992";

                Student stella = new Student()
                {
                    FirstName = "Stella",
                    LastName = "Markova"
                };
                stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

                Console.WriteLine(
                    "{0} older than {1} -> {2}",
                    peter.FirstName,
                    stella.FirstName,
                    peter.IsOlderThan(stella));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        private static string ConvertIntNumberToStringDigit(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Invalid number! The number must be in range 0 - 9!");
            }
        }

        private static int FindMaxNumber(params int[] elements)
        {
            int maxNumber = 0;

            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Number can not be empty!");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                elements[0] = maxNumber;

                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        private static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        private static double CalculateDistanceBetweenTwoPoints(
            double x1,
            double y1,
            double x2,
            double y2,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = y1.Equals(y2);
            isVertical = x1.Equals(x2);

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }
    }
}
