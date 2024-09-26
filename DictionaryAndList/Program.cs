List<string> students = new List<string> { "amit", "toma", "goswami", "shuvro", "golu" };
//create a dictionary to store the students grade
Dictionary<string, int> studentGrades = new Dictionary<string, int>();

//adding grades of each student
studentGrades["amit"] = 85;
studentGrades["toma"] = 95;
studentGrades["goswami"] = 91;
studentGrades["shuvro"] = 87;
studentGrades["golu"] = 79;

Console.WriteLine("Student Grades:");
foreach(var student in students)
{
    Console.WriteLine($"{student}:{studentGrades[student]}");
}

Console.WriteLine("\nEnter the name of the student whose grade you want to update:");
string studentName = Console.ReadLine();
if (studentGrades.ContainsKey(studentName))
{
    Console.WriteLine($"Current grade for {studentName}: {studentGrades[studentName]}");
    Console.WriteLine("Enter a New Grade");
    int newGrade = int.Parse(Console.ReadLine());

    //update the grade
    studentGrades[studentName] = newGrade;
    Console.WriteLine("\n Grade updated successfully");
}
else
{
    Console.WriteLine("Student Not found");
}

//display the updated list of students and grades
Console.WriteLine("\n updated student grade");
foreach(var student in students)
{
    Console.WriteLine($"{student}:{studentGrades[student]}");
}








