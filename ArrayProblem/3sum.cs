using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class _3sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            // List to store the result
            IList<IList<int>> result = new List<IList<int>>();

            // Sort the array
            Array.Sort(nums);

            // Iterate through the array
            for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicate values for 'i'
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                // Use two-pointer technique
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Move the left pointer and skip duplicates
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        // Move the right pointer and skip duplicates
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        // Move both pointers after finding a valid triplet
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;  // Increase sum by moving left pointer
                    }
                    else
                    {
                        right--;  // Decrease sum by moving right pointer
                    }
                }
            }

            return result;
        }
    }
}
