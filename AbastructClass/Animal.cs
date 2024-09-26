using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastructClass
{
    public abstract class Animal
    {
        public abstract void makeSound();
        //non abastract method implementation
        public void sleep()
        {
            Console.WriteLine("Animals are sleeping");
        }
    }
}
