namespace AreaCalculator
{
    public class Circle : IShape
    {
        private double radius { get; set; }

        public Circle(double radius) {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            if (radius < 0)
            {
                throw new ArgumentException("The radius cannot be negative.");
            }
            if (radius == 0)
            {
                throw new ArgumentException("The radius cannot be zero. This is point.");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
