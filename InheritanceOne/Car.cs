using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOne
{
    public class Car : Vehical
    {
        public void Honk()
        {
            Console.WriteLine($"{Brand} is honking!");
        }
    }
}
