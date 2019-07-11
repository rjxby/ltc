using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementStrStr
{
    public class Logic
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            var result = -1;
            for (var i = 0; i < haystack.Length; i++)
            {
                var countPass = 0;
                for (var j = 0; j < needle.Length; j++)
                {
                    if (i + j >= haystack.Length || haystack[i + j] != needle[j])
                    {
                        break;
                    }

                    countPass++;
                }

                if (countPass == needle.Length)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}