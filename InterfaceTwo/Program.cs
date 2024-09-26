using InterfaceTwo;

IAnimal myDog = new Dog("spot");
IAnimal myCat = new Cat("lkajfak");

Console.WriteLine($"Dog's name: {myDog.Name}");

myDog.MakeSound();
myDog.Move();

myCat.MakeSound();
myCat.Move();