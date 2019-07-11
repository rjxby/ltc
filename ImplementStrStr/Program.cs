using System;

namespace ImplementStrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(); 
            Console.WriteLine($"'mississippi - ' - {logic.StrStr("mississippi", "issipi")}");
            //Console.WriteLine($"' - ' - {logic.StrStr("", "a")}");
            Console.ReadLine(); 
        }
    }
}
