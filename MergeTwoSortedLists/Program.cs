using System;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(); 
            
            var first = new ListNode(1);
            first.next = new ListNode(2);
            first.next.next = new ListNode(4);

            var second = new ListNode(1);
            second.next = new ListNode(3);
            second.next.next = new ListNode(4);

            Console.WriteLine($"'()' - {logic.MergeTwoLists(first, second)}");
            Console.ReadLine();
        }
    }
}
