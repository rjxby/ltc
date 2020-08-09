using System;

namespace TopKFrequentWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic();
            var array = new string[] { "i", "love", "leetcode", "i", "love", "coding" };
            var k = 2;
            Console.WriteLine($"'i' and 'love' are the two most frequent words. Note that 'i' comes before 'love' due to a lower alphabetical order - {string.Join(',', logic.TopKFrequent(array, k))}");
        }
    }
}
