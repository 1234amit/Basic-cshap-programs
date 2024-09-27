List<string> employees = new List<string> {"anu","afafa","agaga","gsbs","ssbs" };
//create a dictionary to store employees and their departments
Dictionary<string, string> employeeDepartments =  new Dictionary<string, string>();
//adding department for each employee
employeeDepartments["anu"] = "GM";
employeeDepartments["afafa"] = "HR";
employeeDepartments["agaga"] = "developer";
employeeDepartments["gsbs"] = "agfagagaga";
employeeDepartments["ssbs"] = "engineer";

//Display all employees and their department
Console.WriteLine("Employees and their department");
foreach (var employee in employees)
{
    Console.WriteLine($"{employee}: {employeeDepartments[employee]}");
}

// Step 4: Allow the user to update the department of a specific employee
Console.WriteLine("\nEnter the name of the employee whose department you want to update:");
string employeeName = Console.ReadLine();

if (employeeDepartments.ContainsKey(employeeName))
{
    Console.WriteLine($"Current department for {employeeName}: {employeeDepartments[employeeName]}");
    Console.WriteLine("Enter the new department:");
    string newDepartment = Console.ReadLine();

    // Update the department
    employeeDepartments[employeeName] = newDepartment;

    Console.WriteLine("\nDepartment updated successfully.");
}
else
{
    Console.WriteLine("Employee not found.");
}

// Step 5: Display the updated list of employees and departments
Console.WriteLine("\nUpdated Employees and their Departments:");
foreach (var employee in employees)
{
    Console.WriteLine($"{employee}: {employeeDepartments[employee]}");
}