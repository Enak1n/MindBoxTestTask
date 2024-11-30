using GeometryLibrary.Factories;

var circleFabric = new CircleFactory(1);

var circle = circleFabric.CreateShape();

Console.WriteLine($"Площадь круга равен {circle.CalculateArea()}");

var triangleFactory = new TriangleFactory(3, 5, 6);

var triangle = triangleFactory.CreateShape();

Console.WriteLine($"Площадь треугольника равна {triangle.CalculateArea()}");