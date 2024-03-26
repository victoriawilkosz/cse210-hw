using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Create instances of different shapes and add them to the list
        Square square = new Square("Red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 4, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 6);
        shapes.Add(circle);

        // Iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
            // Get color and area for each shape
            string color = shape.GetColor();
            double area = shape.GetArea();

            // Display color and area of each shape
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}