using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElements
{
    public class MajorityElementsclass
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach(var num in nums)
            {
                if(count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}
