using System;
using System.Collections.Generic;
using System.Linq;

namespace NonDecreasingArray
{
    public class Logic
    {
        public bool CheckPossibility(int[] nums)
        {
            var p = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    if (p != -1) return false;
                    else p = i;
                }
            }
            
            return (p == -1 ||   // no reversed pair
                    p == 1 || p == nums.Length - 1 ||  // reversed pair is first or last element
                    nums[p - 2] <= nums[p] || nums[p - 1] <= nums[p + 1]); // normal case range [p-2 --> p+1] all valid
        }
    }
}