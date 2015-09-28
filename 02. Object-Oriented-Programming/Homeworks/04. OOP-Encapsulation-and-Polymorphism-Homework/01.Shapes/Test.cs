using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shapes
{
    class Test
    {
        static void Main()
        {
            try
            {
                List<BasicShape> shapes = new List<BasicShape>()
                {
                    new Circle(1.5),
                    new Circle(3),
                    new Rectangle(1.5, 3),
                    new Rectangle(5, 4),
                    new Triangle(3, 4, 5),
                    new Triangle(5, 4, 5)
                };
                foreach (BasicShape shape in shapes)
                {
                    Console.WriteLine("Shape {0}\nPerimeter = {1}\nArea = {2}\n", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
