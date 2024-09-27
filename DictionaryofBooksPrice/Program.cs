//create a dictionary to store books adn their prices
Dictionary<string, double> booksPrices = new Dictionary<string, double>();

//Adding books and prices into the dictionary
booksPrices["The Grate Gatsby"] = 10.99;
booksPrices["tak tuk tak"] = 89.23;
booksPrices["sakfjhajkcn"] = 34.23;
booksPrices["akdfjakjfka"] = 23.53;
booksPrices["ajfkajkafa"] = 90.23;

//display all the books and their prices
Console.WriteLine("Available books and prices:");
foreach(var book in booksPrices)
{
    Console.WriteLine($"{book.Key}: ${book.Value}");

}
// Step 3: Allow the user to search for a book and display its price
Console.WriteLine("\nEnter the title of the book you want to search for:");
string bookTitle = Console.ReadLine();

if (booksPrices.ContainsKey(bookTitle))
{
    Console.WriteLine($"{bookTitle} costs ${booksPrices[bookTitle]}");
}
else
{
    Console.WriteLine("Book not found");
}


