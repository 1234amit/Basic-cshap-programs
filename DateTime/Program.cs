DateTime now = DateTime.Now;
Console.WriteLine("Current date and time: " + now);

//utc(coordinated universel time)date and time
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine("Current utc date and time: " + now);

// Specific date and time
DateTime specificDate = new DateTime(2023, 9, 22, 14, 30, 0);  // Year, Month, Day, Hour, Minute, Second
Console.WriteLine("Specific Date and Time: " + specificDate);

// Date only
DateTime onlyDate = new DateTime(2023, 9, 22);
Console.WriteLine("Date only: " + onlyDate.ToShortDateString());