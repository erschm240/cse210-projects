using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 2));
        shapes.Add(new Rectangle("Yellow", 2, 4));
        shapes.Add(new Circle("Green", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"This is a {shape.GetColor()} circle with an area of {shape.GetArea()}.");
        }
    }
}