using AreaCalculator;

Triangle triangle = new Triangle(3, 3, 5);
Console.WriteLine("Площадь фигуры (треугольник): " + triangle.CalculateArea().ToString());
Console.WriteLine("----------------------");


ShapeCalculator shapeCalculator = new ShapeCalculator();
List<dynamic> shapes = new List<dynamic>
        {
            new Circle(5),
        };
foreach (var shape in shapes)
{
    double area = shapeCalculator.CalculateArea(shape);
    Console.WriteLine("Площадь фигуры: " + area);
}

Console.ReadLine();