using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> {
            new Square("Green", 5),
            new Rectangle("Blue", 4, 5),
            new Circle("Yellow", 3)
        };
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape Color:{s.GetColor()}, Area:{s.GetArea()}");
        }
    }
}