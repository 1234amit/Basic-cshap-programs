using InheritanceOne;

Car myCar = new Car();
myCar.Brand = "Toyota";
myCar.Speed = 120;
myCar.Drive();
myCar.Honk();

Console.WriteLine(); // Empty line for better readability

// Create an object of the derived class Bicycle
Bicycle myBicycle = new Bicycle();
myBicycle.Brand = "Giant";
myBicycle.Speed = 25;
myBicycle.Drive();
myBicycle.RingBell();

//Console.ReadLine();