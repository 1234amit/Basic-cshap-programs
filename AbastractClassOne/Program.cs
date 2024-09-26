using AbastractClassOne;

Shape circle = new Circle(5);      // Circle with radius 5
Shape rectangle = new Rectangle(4, 6); // Rectangle with width 4 and height 6

// Displaying area of each shape
Console.WriteLine("Area of Circle: " + circle.CalculatedArea());       // Output: 78.53981633974483
Console.WriteLine("Area of Rectangle: " + rectangle.CalculatedArea()); // Output: 24
