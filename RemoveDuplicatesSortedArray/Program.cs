using System;

namespace RemoveDuplicatesSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(); 
            var array = new int[] { 1, 2, 3, 4, 5, 7, 7, 7, 7, 7, 8, 9 };
            Console.WriteLine($"'8 - ' - {logic.RemoveDuplicates(array)}");
            Console.ReadLine();
        }
    }
}
