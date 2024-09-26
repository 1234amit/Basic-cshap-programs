using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class WaterBottol
    {
        public double water;
        private double capacity;

        //create constructor
        public WaterBottol()
        {
            this.capacity = 0;
        }

        public WaterBottol(double capacity)
        {
            this.capacity = capacity;
        }

        public void AddWater(double amount)
        {
            if(water + amount <= capacity)
            {
                water += amount;
            }
        }
    }
}
