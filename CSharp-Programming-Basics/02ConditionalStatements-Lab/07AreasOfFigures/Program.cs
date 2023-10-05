
string shape = Console.ReadLine();

if (shape == "square")
{
    double side = double.Parse(Console.ReadLine());

    double areaSquare = side * side;
    Console.WriteLine($"{areaSquare:F3}");
}
else if (shape == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());

    double areaRectangle = sideA * sideB;
    Console.WriteLine($"{areaRectangle:F3}");
}
else if (shape == "circle")
{
    double radius = double.Parse(Console.ReadLine());

    double areaCircle = Math.PI * (radius * radius);

    Console.WriteLine($"{areaCircle:F3}");
}
else if (shape == "triangle")
{
    double legth = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    double areaTriangle = (legth * height) / 2;

    Console.WriteLine($"{areaTriangle:F3}");
}