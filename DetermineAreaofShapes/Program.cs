using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var myShapes = new List<Shape> {
            new Circle(5),
            new Rectangle(10, 8),
            new Square(20)
            };

            for(int i = 0; i < myShapes.Count; i++)
            {
                Console.WriteLine($"Shape #{i+1}: \n\tType = {myShapes[i].GetType()}, \n\tArea = {myShapes[i].Area}");
            }
        }
    }
}
