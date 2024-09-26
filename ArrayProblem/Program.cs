//leetcode 1st problem 
//two sum

//using ArrayProblem;

//Solution solution = new Solution();

//int[] nums1 = { 2, 7, 11, 15 };
//int target1 = 9;
//int[] result1 = solution.TwoSum(nums1, target1);
//Console.WriteLine($"Result: [{result1[0]}, {result1[1]}]"); // Output: [0, 1]

//int[] nums2 = { 3, 2, 4 };
//int target2 = 6;
//int[] result2 = solution.TwoSum(nums2, target2);
//Console.WriteLine($"Result: [{result2[0]}, {result2[1]}]"); // Output: [1, 2]

//int[] nums3 = { 3, 3 };
//int target3 = 6;
//int[] result3 = solution.TwoSum(nums3, target3);
//Console.WriteLine($"Result: [{result3[0]}, {result3[1]}]"); // Output: [0, 1]


//3sum program
//using ArrayProblem;

//_3sum solution = new _3sum();
//int[] nums1 = { -1, 0, 1, 2, -1, -4 };
//var result1 = solution.ThreeSum(nums1);
//PrintResult(result1); // Output: [[-1, -1, 2], [-1, 0, 1]]

//int[] nums2 = { 0, 1, 1 };
//var result2 = solution.ThreeSum(nums2);
//PrintResult(result2); // Output: []

//int[] nums3 = { 0, 0, 0 };
//var result3 = solution.ThreeSum(nums3);
//PrintResult(result3); // Output: [[0, 0, 0]]


//static void PrintResult(IList<IList<int>> result)
//{
//    foreach(var triplet in result)
//    {
//        Console.WriteLine($"[{string.Join(", ", triplet)}]"); 
//    }
//}


//4 sum
//using ArrayProblem;

//_4sun solution = new _4sun();
//int[] nums = { 1, 0, -1, 0, -2, 2 };
//var result1 = solution.FourSum(nums, 0);
//Console.WriteLine(result1);



//using ArrayProblem;

//Solutionone solutionone = new Solutionone();
//int[] nums = { 1, 2, 3 };

//solutionone.NextPermutation(nums);
//Console.WriteLine(string.Join(", ", nums));


//using ArrayProblem;

//int[][] matrix = {
//            new int[] {1, 2, 3},
//            new int[] {4, 5, 6},
//            new int[] {7, 8, 9}
//        };

//MatrixRotation solution = new MatrixRotation();
//Console.WriteLine("Original Matrix:");
//solution.PrintMatrix(matrix);

//solution.Rotate(matrix);

//Console.WriteLine("Rotated Matrix:");
//solution.PrintMatrix(matrix);


//using ArrayProblem;

//MergeSortArray solution = new MergeSortArray();

//int[] nums1 = { 1, 2, 3, 0, 0, 0 };
//int m = 3;
//int[] nums2 = { 2, 5, 6 };
//int n = 3;
//solution.merge(nums1, m, nums2, n);
//Console.WriteLine("Example 1 Output: " + string.Join(", ", nums1));



using ArrayProblem;

GroupAnagram solution = new GroupAnagram();

// Example 1
string[] strs1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
IList<IList<string>> result1 = solution.GroupAnagrams(strs1);
//PrintResult(result1);
Console.WriteLine(result1);

// Example 2
string[] strs2 = { "" };
IList<IList<string>> result2 = solution.GroupAnagrams(strs2);
//PrintResult(result2);
Console.WriteLine(result2);

// Example 3
string[] strs3 = { "a" };
IList<IList<string>> result3 = solution.GroupAnagrams(strs3);
//PrintResult(result3);
Console.WriteLine(result3);

// Helper function to print the result
//public static void PrintResult(IList<IList<string>> result) // Make the method static
//{
//    Console.WriteLine("[");
//    foreach (var group in result)
//    {
//        Console.Write("  [");
//        Console.Write(string.Join(", ", group));
//        Console.WriteLine("]");
//    }
//    Console.WriteLine("]");
//}













