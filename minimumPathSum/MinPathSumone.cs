using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumPathSum
{
    public class MinPathSumone
    {
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            // Create a DP array of the same size as grid
            int[,] dp = new int[m, n];

            // Initialize the top-left corner
            dp[0, 0] = grid[0][0];

            // Fill in the first row (only move right)
            for (int j = 1; j < n; j++)
            {
                dp[0, j] = dp[0, j - 1] + grid[0][j];
            }

            // Fill in the first column (only move down)
            for (int i = 1; i < m; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + grid[i][0];
            }

            // Fill in the rest of the dp table
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = grid[i][j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            // The bottom-right corner contains the result
            return dp[m - 1, n - 1];
        }
    }
}
