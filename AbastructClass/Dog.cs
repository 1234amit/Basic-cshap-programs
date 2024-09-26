using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastructClass
{
    internal class Dog:Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("The dogs bark wof wof");
        }
    }
}
