using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElement
{
    public class Logic
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int length = nums.Length;
            while (i < length)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[length - 1];
                    length--;
                }
                else
                {
                    i++;
                }
            }
            return length;
        }
    }
}