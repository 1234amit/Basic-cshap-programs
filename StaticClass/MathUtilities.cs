using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class MathUtilities
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static int divide(int a, int b) {
            if (b == 0)
            {
                throw new DivideByZeroException("Can not devide by zero");
            }

            return a / b;
        }
    }
}
