using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square(2, "Blue");

        Console.WriteLine(square1.GetArea());
        Console.WriteLine(square1.GetShapeColor());
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle(2, 4, "Red");

        Console.WriteLine(rectangle1.GetArea());
        Console.WriteLine(rectangle1.GetShapeColor());

        rectangle1.SetShapeColor("White");
        Console.WriteLine(rectangle1.GetShapeColor());
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(3, "Orange");
        Console.WriteLine(circle1.GetArea());
        Console.WriteLine(circle1.GetShapeColor());
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetShapeColor();

            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Area: {area}");
        }
    }
}