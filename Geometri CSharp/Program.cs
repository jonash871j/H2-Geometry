using System;
using System.Collections.Generic;
using Geometry;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(32);
        Rectangle rectangle1 = new Rectangle(24, 8);
        Parallelogram parallelogram1 = new Parallelogram(3, 5, 20);
        Trapeze trapeze1 = new Trapeze(10, 9, 8, 9);
        Triangle triangle1 = new Triangle(16, 32);

        List<Shape> shapes = new List<Shape>() 
        { 
            square1, 
            rectangle1, 
            parallelogram1, 
            trapeze1, 
            triangle1 
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.ToString());
        }
    }
}