using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Bike:IVehical
    {
        public string Brand { get; set; }
        public Bike(string brand)
        {
            Brand = brand;
        }
        public void start()
        {
            Console.WriteLine($"{Brand} bike is starting");
        }

        public void stop()
        {
            Console.WriteLine($"{Brand} bike is stoping");
        }
    }
}
