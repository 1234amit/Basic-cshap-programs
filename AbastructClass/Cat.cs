using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastructClass
{
    internal class Cat:Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("The cat meows: Meow!");
        }
    }
}
