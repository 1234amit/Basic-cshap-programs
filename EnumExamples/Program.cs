void printGettings(string name, uint type)
{
    if (type == 0)
    {
        Console.WriteLine("Dear sir " + name);
    }
    else if (type == 1)
    {
        Console.WriteLine("Dear Mam " + name);
    }
}

printGettings("tareq", 3);