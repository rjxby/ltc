using System;

namespace NonDecreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic();
            var array = new int[] { 4, 2, 1 };
            Console.WriteLine($"- {logic.CheckPossibility(array)}");
        }
    }
}
