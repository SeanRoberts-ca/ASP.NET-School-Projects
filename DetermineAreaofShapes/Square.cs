using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
   class Square : Rectangle
    {
        public double Side { get; set; }
        public Square(double side) : base(side, side)
        {

        }
    }

}
