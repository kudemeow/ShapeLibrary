namespace ShapeLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");

            Radius = radius;
        }

        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
