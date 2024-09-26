using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;
        public int Age;

        //create constructor
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }
    }
}
