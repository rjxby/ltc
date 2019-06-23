using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(); 
            Console.WriteLine($"['flower','flow','flight'] - {logic.LongestCommonPrefix(new string[]{"flower","flow","flight"})}");
            Console.WriteLine($"['dog','racecar','car'] - {logic.LongestCommonPrefix(new string[]{"dog","racecar","car"})}");
            Console.WriteLine($"['',''] - {logic.LongestCommonPrefix(new string[]{"",""})}");
            Console.WriteLine($"['a'] - {logic.LongestCommonPrefix(new string[]{"a"})}");    
            Console.WriteLine($"['c','c'] - {logic.LongestCommonPrefix(new string[]{"c","c"})}");  
            Console.WriteLine($"['aa','aa'] - {logic.LongestCommonPrefix(new string[]{"aa","aa"})}");  
            Console.WriteLine($"['a','a','b'] - {logic.LongestCommonPrefix(new string[]{"a","a","b"})}"); 
            Console.WriteLine($"['aac','a','ccc'] - {logic.LongestCommonPrefix(new string[]{"aac","a","ccc"})}");  
            Console.ReadLine();
        }
    }
}
