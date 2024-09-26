using ArrayProblem;
using System;

namespace ArrayProblem
{
    public class Solutionone
    {
        // Method to find the next permutation
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length;
            int i = n - 2;

            // Step 1: Find the first decreasing element from the end
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            // Step 2: If a decreasing element is found, find the next larger element to swap
            if (i >= 0)
            {
                int j = n - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);  // Swap nums[i] and nums[j]
            }

            // Step 3: Reverse the subarray after the i-th position
            Reverse(nums, i + 1, n - 1);
        }

        // Helper function to swap two elements in the array
        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        // Helper function to reverse the elements in the array between indices start and end
        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
        }
    }
}

