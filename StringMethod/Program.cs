string s = "Hello world";
int index = s.IndexOf('w');
Console.WriteLine(index);

bool result = s.Contains("wo");
Console.WriteLine(result);

static string ConcatinateString(string str1, string str2)
{
    return str1 + str2;
}

string firstName = "Amit";
string lastName = "Goswami";
string fullName = ConcatinateString(firstName, lastName);
Console.WriteLine(fullName);



static int GetStringLength(string str)
{
    return str.Length;
}

int length = GetStringLength(fullName);
Console.WriteLine("Length of the full name: " + length);

//convert to the uppercase
static string ConvertToUpper(string str)
{
    return str.ToUpper();
}
string uppercaseName = ConvertToUpper(fullName);
Console.WriteLine("Full Name in uppercase: " + uppercaseName);

//convert to the lowercase
static string ConvertToLower(string str)
{
    return str.ToLower();
}
string lowercaseName = ConvertToLower(fullName);
Console.WriteLine("Full Name in LowerCase: " + lowercaseName);

// Method to check if a string contains a substring

static bool CheckSubstring(string mainString, string subString)
{
    return mainString.Contains(subString);
}

bool contains = CheckSubstring(fullName, "Goswami");
Console.WriteLine("Does the full name contain Goswami " + contains);

//Method to reverse a string
static string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string reverseName = ReverseString(fullName);
Console.WriteLine(reverseName);











