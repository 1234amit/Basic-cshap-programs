
//int sum = 0;
//int count = int.Parse(Console.ReadLine());

//for(int i=0; i<count; i++)
//{
//    sum += int.Parse(Console.ReadLine());
//}

//int average = sum / 5;

//Console.WriteLine(average);


//static void myMethod()
//{
//    Console.WriteLine("Hello amit how are you");
//}

//myMethod();

//method example

static int AddTwoNumber(int a, int b)
{
    return a + b;
}

//method for get the user
static void getUser(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}

//method to check if a number is even or odd
static void CheckEvenOdd(int number)
{
    if(number % 2 == 0)
    {
        Console.WriteLine(number + " Is a Even Number");
    }
    else
    {
        Console.WriteLine(number + "Is a odd number");
    }
}

int result = AddTwoNumber(5, 250);
Console.WriteLine(result);

getUser("Amit");

Console.WriteLine("Enter a number check even or odd");
int number = int.Parse(Console.ReadLine());
CheckEvenOdd(number);

























