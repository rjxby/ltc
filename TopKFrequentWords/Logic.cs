using System;
using System.Collections.Generic;
using System.Linq;

namespace TopKFrequentWords
{
    public class Logic
    {
        public IList<string> TopKFrequent(string[] words, int k) 
        {
            var wordsCounter = new Dictionary<string, int>();
            foreach(var uniqWord in words.Distinct())
            {
                wordsCounter.Add(uniqWord, words.Where(w => uniqWord == w).Count()); 
            }
            
            return wordsCounter
                .OrderBy(dic => dic.Key)
                .OrderByDescending(dic => dic.Value)
                .Select(dic => dic.Key)
                .Take(k)
                .ToList();
        }
    }
}