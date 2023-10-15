using AreaCalculator;

namespace AreaCalculatorTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateArea_ValidData_CorrectResult()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.AreEqual(6, area, 0.001);  // Accept a small error due to double precision
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_InvalidData_ThrowException()
        {
            double sideA = 0;
            double sideB = 0;
            double sideC = 0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            triangle.CalculateArea(); 
        }

        [TestMethod]
        public void IsRightTriangle_ValidData_CorrectResultTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightTriangle = triangle.isRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void IsRightTriangle_ValidData_CorrectResultFalse()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightTriangle = triangle.isRightTriangle();

            Assert.IsFalse(isRightTriangle);
        }
    }
}
