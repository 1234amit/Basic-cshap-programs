using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTwo
{
    public class Cat:IAnimal
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("The cat purrs when I scratch his head.");
        }

        public void Move()
        {
            Console.WriteLine("The cat only moves when there is food in his bowl.");
        }
    }
}
