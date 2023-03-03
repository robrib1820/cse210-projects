using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square area1 = new Square("Blue", 5);
        shapes.Add(area1);

        Rectangle area2 = new Rectangle("Red", 5, 6);
        shapes.Add(area2);

        Circle area3 = new Circle("Yellow", 8);
        shapes.Add(area3);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} - {shape.GetArea()} ");
        }
    }
}