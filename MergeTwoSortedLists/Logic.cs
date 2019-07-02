using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeTwoSortedLists
{
    public class Logic
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        result = InsertToEndList(result, new ListNode(l1.val));
                        l1 = l1.next;
                        continue;
                    }

                    result = InsertToEndList(result, new ListNode(l2.val));
                    l2 = l2.next;
                    continue;
                }

                if (l1 != null)
                {
                    result = InsertToEndList(result, new ListNode(l1.val));
                    l1 = l1.next;
                    continue;
                }

                result = InsertToEndList(result, new ListNode(l2.val));
                l2 = l2.next;
            }

            return result;
        }

        public ListNode InsertToEndList(ListNode head, ListNode target)
        {
            if (head == null)
            {
                head = target;
                return head;
            }

            var tmp = head;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = target;

            return head;
        }
    }
}