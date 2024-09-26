using Inheritance;

Animal animal = new Animal("Generic Animal");
animal.Eat();
animal.sound();

Console.WriteLine();

//create an instance of the derived class
Dog dog = new Dog("Buddy");
dog.Eat();
dog.Bark();
dog.sound();

Console.WriteLine();