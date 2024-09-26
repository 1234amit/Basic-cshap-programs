using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTwo
{
    public class Dog:IAnimal
    {
        public string Name { set; get; }
        public Dog(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("The dog barks when he is happy to see me");
        }

        public void Move()
        {
            Console.WriteLine("The dog moves when he sees his best friend");
        }
    }
}
