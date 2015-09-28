namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public override string ToString()
        {
            return string.Format("I am a {0}. " + "My perimeter is {1:f2}. My area is {2:f2}.", this.GetType().Name, this.CalculatePerimeter(), this.CalculateArea());
        }
    }
}
