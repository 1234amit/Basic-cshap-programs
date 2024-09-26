using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractClassOne
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        //create constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatedArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
