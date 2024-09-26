using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public double Speed;

        //constructor to initialize a new car object
        public Car(string brand, string model, int year, double speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = speed;
        }

        //display car info
        public void DisplayCarInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Speed: " + Speed);
        }

        public void Accelerate(double increment)
        {
            Speed += increment;
            Console.WriteLine("The car accelerated by "
                + increment + " km/h. New speed: " + Speed + " km/h");
        }

        public void Break(double decrement)
        {
            Speed -= decrement;
            if (Speed < 0) Speed = 0;
            Console.WriteLine("The car slowed down by "
                + decrement + " km/h. New speed: " + Speed + " km/h");

        }
    }
}
