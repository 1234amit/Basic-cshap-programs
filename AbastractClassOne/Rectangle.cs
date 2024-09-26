using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractClassOne
{
    public class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //create constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculatedArea()
        {
            return Width * Height;
        }

    }
}
