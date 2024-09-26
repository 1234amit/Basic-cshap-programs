//array example
//int[] numbers = new int[5];

////input elements into the array
//Console.WriteLine("Enters 5 numbers: ");
//for(int i=0; i<numbers.Length; i++)
//{
//    Console.WriteLine("Enter Number: "+(i+1)+ ": ");
//    numbers[i] = int.Parse(Console.ReadLine());
//}

////display all elements in the array
//Console.WriteLine("\nYou enter the following number");
//foreach(int num in numbers)
//{
//    Console.WriteLine(num+ "");
//}

////calculate the sum of the array elements
//int sum = 0;
//foreach(int num in numbers)
//{
//    sum += num;
//}

//Console.WriteLine("Sum of the array elements: " + sum);

////Find the largest number of array
//int largest = numbers[0];
//for(int i=1; i<numbers.Length; i++)
//{
//    if (numbers[i] > largest)
//    {
//        largest = numbers[i];
//    }
//}

//Console.WriteLine(largest);


////Find the smallest number of array
//int smallestNumber = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] < smallestNumber)
//    {
//        smallestNumber = numbers[i];
//    }
//}

//Console.WriteLine(smallestNumber);


//_ = new int[][]
//{
//    new int[]{79,89},
//    new int[]{80,68,56 },
//    new int[]{57,34,88,92}

//};

//int count = int.Parse(Console.ReadLine());

//int[][] dynamicJaggedArray = new int[count][];

//for(int i=0; i <= count; i++)
//{
//    int items = int.Parse(Console.ReadLine());
//    dynamicJaggedArray[i] = new int[items];

//    for(int j=0; j<items; j++)
//    {
//        int item = int.Parse(Console.ReadLine());
//        dynamicJaggedArray[i][j] = item;
//    }
//}

//array example
//reverse array

int[] numbers = new int[4];

//input elements into the array
Console.WriteLine("Enter 4 numbers: ");
for(int i=0; i<numbers.Length; i++)
{
    Console.WriteLine("Enter Number "+(i+1)+":");
    numbers[i] = int.Parse(Console.ReadLine());
}

//Display the original array
Console.WriteLine("\nOriginal Array: ");
foreach(int num in numbers)
{
    Console.WriteLine(num);
}

//Reverse the array
Array.Reverse(numbers);
//Display the reverse array
Console.WriteLine("\nReverse Array:");
foreach(int num in numbers)
{
    Console.WriteLine(num);
}










































