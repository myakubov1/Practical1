using AreaCalculator;

namespace AreaCalculatorTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea_ValidData_CorrectResult()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.CalculateArea();

            Assert.AreEqual(78.54, area, 0.001); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_InvalidData_ThrowException()
        {
            double radius = 0;
            Circle circle = new Circle(radius);

            circle.CalculateArea();
        }

    }
}
