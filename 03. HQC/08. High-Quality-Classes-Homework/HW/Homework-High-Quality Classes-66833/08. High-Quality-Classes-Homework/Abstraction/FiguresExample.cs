namespace Abstraction
{
    using System;

    public static class FiguresExample
    {
        public static void Main()
        {
            IFigure circle = new Circle(5);
            Console.WriteLine(circle);
            IFigure rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle);
        }
    }
}
