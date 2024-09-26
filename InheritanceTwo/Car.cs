using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTwo
{
    public class Car
    {
        private int id;
        protected int Serial { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        //create constructor
        public Car()
        {
            id = 1000;
        }

        public void StartEnginee()
        {
            Console.WriteLine($"Enginee Started, id:{id}");
        }
    }
}
