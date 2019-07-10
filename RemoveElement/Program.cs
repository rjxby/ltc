using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(); 
            var array = new int[] { 1, 4, 3, 4 };
            Console.WriteLine($"'without 4 - ' - {logic.RemoveElement(array, 4)}");
            var array1 = new int[] { 1 };  
            Console.WriteLine($"'without 1 - ' - {logic.RemoveElement(array1, 1)}");
            Console.ReadLine();
        }
    }
}
