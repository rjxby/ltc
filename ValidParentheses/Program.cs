using System;

namespace TrimBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(); 
            Console.WriteLine($"'()' - {logic.IsValid("()")}");
            Console.ReadLine();
        }
    }
}
