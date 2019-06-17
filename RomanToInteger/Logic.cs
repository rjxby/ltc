using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInteger
{
    public class Logic
    {
        private Dictionary<char, int> ValuesMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException(nameof(s));
            }

            var list = new List<int>();
            foreach (var ch in s)
            {
                int val = 0;
                if (!ValuesMap.TryGetValue(ch, out val))
                {
                    throw new ArgumentException(nameof(s));
                }

                list.Add(val);
            }

            int result = 0;
            for (var i = 0; i < list.Count; i++)
            {
                var item = list[i];
                if (i != list.Count - 1 && item < list[i + 1])
                {
                    result += GetValue(list[i + 1], list.Skip(i + 1).ToList()) - item;
                    i++;
                } 
                else
                {
                    result += item;
                }
            }

            return result;
        }

        private int GetValue(int item, List<int> list)
        {
            if (list.Count == 0 || item >= list.FirstOrDefault())
            {
                return item;
            }

            return GetValue(list.FirstOrDefault(), list.Skip(1).ToList()) - item;
        }
    }
}