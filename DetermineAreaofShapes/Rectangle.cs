using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width) {
            Height = height; 
            Width = width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    }
}
