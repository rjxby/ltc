using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicatesSortedArray
{
    public class Logic
    {
        public int RemoveDuplicates(int[] array) 
        {
            var lastIndex = array.Length - 1; 
            var lastResultIndex = lastIndex;
            for (var i = 0; i < lastIndex;)
            {
                if (array[i] == array[i + 1])
                {
                    if(array[i] == array[lastIndex])
                    {
                        lastResultIndex = i;
                        break;
                    }

                    for (var j = i + 1; j <= lastIndex - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }

                    continue;
                }

                i++;
            }

            return array.Take(lastResultIndex + 1).ToArray().Length;
        }
    }
}