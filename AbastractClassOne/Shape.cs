using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractClassOne
{
    public abstract class Shape
    {
        public abstract double CalculatedArea();
        public void display()
        {
            Console.WriteLine("This is a shape");
        }
    }
}
