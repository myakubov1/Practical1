namespace AreaCalculator
{
    public class Triangle : ITriangle
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }

        public Triangle (double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("The sides do not form a valid triangle.");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        private bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            bool isSideAValid = sideA > 0;
            bool isSideBValid = sideB > 0;
            bool isSideCValid = sideC > 0;

            bool areSidesValid = isSideAValid && isSideBValid && isSideCValid;

            bool areTriangleSidesValid = sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;

            return areSidesValid && areTriangleSidesValid;
        }

        public bool isRightTriangle()
        {
            return sideA * sideA + sideB * sideB == sideC * sideC;
        }

    }
}
