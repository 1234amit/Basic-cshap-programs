using Interface;

IVehical car = new Car("Toyota");
IVehical bike = new Bike("Imaha");

car.start();  // Output: Toyota car is starting.
car.stop();   // Output: Toyota car is stopping.

bike.start(); // Output: Yamaha bike is starting.
bike.stop();  // Output: Yamaha bike is stopping.