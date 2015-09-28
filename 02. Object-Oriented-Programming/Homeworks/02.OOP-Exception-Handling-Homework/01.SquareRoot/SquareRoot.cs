using System;
using System.Collections.Generic;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a positive number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Sqrt(number));

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error: " + ex.ParamName);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number!");
            }
            return Math.Sqrt(value);
        }
    }
}
