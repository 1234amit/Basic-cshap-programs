using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    public class People
    {
        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public static string GreetUser(string name)
        {
            return "Hello" + name + "!";
        }

        public static void printMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayInfo(string name, int age = 17)
        {
            Console.WriteLine("Name: "+name+", Age: "+age);

        }
    }
}
