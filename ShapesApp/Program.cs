using Shapes;
using System;
using System.Collections.Generic;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(3, 4, 5);
            Circle cr = new Circle(2);
            // числение площади фигуры без знания типа фигуры
            // Я не очень понял что имеется ввиду, но есть идея)))
            List<Shape> shapes = new List<Shape>();
            shapes.Add(tr);
            shapes.Add(cr);
            foreach(Shape shp in shapes)
            {
                Console.WriteLine(shp.Square()); // "без знания"...
            }
            Console.ReadKey();
        }
    }
}
