int a = 10;
int b = 30;

int sum = a + b;
int remainder = a % b;

Console.WriteLine(sum);
Console.WriteLine(remainder);

//bool examples 
bool isEqual = a == b;
Console.WriteLine(isEqual);

bool isGreater = a > b;
Console.WriteLine(isGreater);

bool isSmaller = a < b;
Console.WriteLine(isSmaller);

//conditions
bool condition1 = true;
bool condition2 = false;

bool result = condition1 && condition2;
bool result1 = condition1 || condition2;
Console.WriteLine(result);
Console.WriteLine(result1);


Console.WriteLine("----------------------------------------------------");

int num = 10;
int result3 = num += 5;
Console.WriteLine(result3);
int increment = num++;
int decrement = result3--;
Console.WriteLine(increment);
Console.WriteLine(decrement);

Console.WriteLine("----------------------------------------------------");

//if else condition
int score = 98;

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score <= 90 && score >= 80)
{
    Console.WriteLine("Grade:B");
}
else if (score <= 80 && score >= 60)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}


//another example
int age = 50;

if(age >= 20)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("boy");
}


//switch case example
int day = 2;

switch (day)
{
    case 1:
        Console.WriteLine("Saterday");
        break;
    case 2:
        Console.WriteLine("Sunday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("forgot days");
        break;
}





























