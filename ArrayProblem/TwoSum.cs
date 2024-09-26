using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //create a dictionary to store
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numToIndex.ContainsKey(complement))
                {
                    return new int[] { numToIndex[complement], i };
                }

                //otherwise store the current number and its index
                if (!numToIndex.ContainsKey(nums[i]))
                {
                    numToIndex[nums[i]] = i;
                }
            }

            throw new ArgumentException("No two sum solution");


        }
    }
}
