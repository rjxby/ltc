using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic();
            Console.WriteLine($"III = {logic.RomanToInt("III")}");
            Console.WriteLine($"IV = {logic.RomanToInt("IV")}");
            Console.WriteLine($"MCMXCIV = {logic.RomanToInt("MCMXCIV")}");
            Console.ReadLine();
        }

    }
}