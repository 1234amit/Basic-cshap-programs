using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        //constructor of the base class
        public Animal(string name)
        {
            Name = name;
        }

        //method
        public void Eat()
        {
            Console.WriteLine(Name + "is eating.");
        }

        public virtual void sound()
        {
            Console.WriteLine(Name + "Make a sound");
        }
    }
}
