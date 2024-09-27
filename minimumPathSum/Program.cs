
using minimumPathSum;
MinPathSumone minPathSumOne = new MinPathSumone();

int[][] grid1 = new int[][]
{
    new int[] { 1, 3, 1 },
    new int[] { 1, 5, 1 },
    new int[] { 4, 2, 1 }
};

// Example grid input 2
int[][] grid2 = new int[][]
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5, 6 }
};

// Call the MinPathSum method and output the result
Console.WriteLine("Minimum Path Sum for Grid 1: " + minPathSumOne.MinPathSum(grid1)); // Output: 7
Console.WriteLine("Minimum Path Sum for Grid 2: " + minPathSumOne.MinPathSum(grid2)); // Output: 12