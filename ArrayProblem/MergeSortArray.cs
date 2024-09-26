using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class MergeSortArray
    {
        public void merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            //compare elements from the end of nums1 and nums2
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1]; // Place the larger element in the correct position
                    p1--; // Move the pointer for nums1
                }
                else
                {
                    nums1[p] = nums2[p2]; // Place the larger element in the correct position
                    p2--; // Move the pointer for nums2
                }
                p--; // Move the pointer for the merged array
            }

            // If there are any remaining elements in nums2, copy them over
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p--;
                p2--;
            }
        }
    }
}
