using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class _4sun
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            //sort the array
            Array.Sort(nums);

            //loop the first number
            for(int i=0; i<nums.Length-3; i++)
            {
                //skip duplicate the first number
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                //loop the second number
                for(int j=i+1; j<nums.Length-2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    //two pointer tecnique for rest of two number
                    int left = j + 1;
                    int right = nums.Length - 1;

                    while(left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                        if(sum == target)
                        {
                            //add quadruplet the result
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                            //skip duplicate from third and fourth numbers
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;

                            left++;
                            right--;
                        }
                        else if(sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
