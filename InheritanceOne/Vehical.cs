using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOne
{
    public class Vehical
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is Driving at {Speed} km/h");
        }
    }
}
