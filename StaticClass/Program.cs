
using StaticClass;

// No need to instantiate the static class
int a = 10;
int b = 20;

// Call static methods directly on the class
Console.WriteLine("Add: " + MathUtilities.Add(a, b));
Console.WriteLine("Subtract: " + MathUtilities.Subtract(a, b));
Console.WriteLine("Multiply: " + MathUtilities.multiply(a, b));
Console.WriteLine("Divide: " + MathUtilities.divide(a, b));