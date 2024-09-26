using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name):base(name) { }

        public void Bark()
        {
            Console.WriteLine(Name + " is Barking");
        }

        public override void sound()
        {
            Console.WriteLine(Name + "Say whoo");
        }
    }
}
