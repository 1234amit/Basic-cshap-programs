int age = 25;
string name = "Amit";
string description = "how are you ?";
double height = 5.9;
bool isStudent = true;


//performing some operations
int nextYearAge = age + 1;
string greetings = "Hello ," + name + description;
double heightInCm = height * 30.48;

Console.WriteLine(isStudent);
Console.WriteLine(greetings);
Console.WriteLine(nextYearAge);
Console.WriteLine(heightInCm);


//Exercise example using c#

string myString = "Hello Amit";
decimal myDecimal = 100.60m;
bool myBoolean = false;

Console.WriteLine(myString);
Console.WriteLine(myDecimal);
Console.WriteLine(myBoolean);

//data structure
string[] myGroceryArray = new string[3];
myGroceryArray[0] = "pineApple";
myGroceryArray[1] = "Apple";
myGroceryArray[2] = "Ice cream";

Console.WriteLine(myGroceryArray[2]);

//directory example
Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
itemPrices["cheese"] = 5.99m;
itemPrices["carrots"] = 2.99m;

Console.WriteLine(itemPrices["cheese"]);
Console.WriteLine(itemPrices["carrots"]);











