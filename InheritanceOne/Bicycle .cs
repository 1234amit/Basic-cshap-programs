using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOne
{
    public class Bicycle:Vehical
    {
        public void RingBell()
        {
            Console.WriteLine($"{Brand} is ringing its bell!");
        }
    }
}
