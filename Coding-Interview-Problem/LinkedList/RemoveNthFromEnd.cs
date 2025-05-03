using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Interview_Problem.LinkedList
{
    public static partial class LinkedList
    {
        //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        public static LinkedList<T> RemoveNthFromEnd<T>(LinkedList<T> head, int n)
        {
            var first = head;
            int i = 0;

            // Move first pointer n steps ahead
            while (first is not null && i < n)
            {
                first = first.Next;
                i += 1;
            }

            // If n is greater than the length of the list
            if (i < n)
                throw new Exception("n is greater than the length of the linked list");

            var second = head;

            // Move both first and second until first reaches the end
            while (first is not null && second is not null)
            {
                second = second.Next;
                first = first.Next;
            }
            second.Next = second.Next?.Next;
            return head;
        }
    }
}
