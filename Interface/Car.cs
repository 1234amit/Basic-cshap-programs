using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Car:IVehical
    {
        public string Brand { get; set; }
        //create constructor
        public Car(string brand)
        {
            Brand = brand;
        }

        public void start()
        {
            Console.WriteLine($"{Brand} car is starting");
        }

        public void stop()
        {
            Console.WriteLine($"{Brand} car is stoping");
        }
    }
}
