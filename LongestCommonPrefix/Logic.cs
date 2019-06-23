using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestCommonPrefix
{
    public class Logic
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) 
            {
                return string.Empty;
            }

            var firstString = strs.First();
            for (int i = 0; i < firstString.Length; i++)
            {
                var c = firstString[i];
                for (int j = 1; j < strs.Length; j ++) 
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);  
                    }           
                }
            }

            return firstString;
        }
    }
}