//create a dictionary
Dictionary<int, string>MyNewDictionary = new Dictionary<int, string>();
//add key value pair 

MyNewDictionary.Add(1128, "welcome");
MyNewDictionary.Add(3345, "alkfjalkf");
MyNewDictionary.Add(3423, "geeksforgeek");

foreach(KeyValuePair<int, string> elem1 in MyNewDictionary)
{
    Console.WriteLine(elem1.Key + ": " + elem1.Value);
}

//another code
Dictionary<string, string> my_dict2 = new Dictionary<string, string>()
{
{"a.1", "Dog"},
    {"a.2", "Cat"},
{"a.3", "Pig"} };

foreach(KeyValuePair<string,string> elem2 in my_dict2)
{
    Console.WriteLine(elem2.Key + ": " + elem2.Value);
}
