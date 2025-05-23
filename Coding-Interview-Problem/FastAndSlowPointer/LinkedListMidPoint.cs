﻿namespace Coding_Interview_Problem.FastAndSlowPointer
{
    public static partial class FastAndSlowPointer
    {
        //https://leetcode.com/problems/middle-of-the-linked-list/description/
        public static LinkedList<T> MiddleNode<T>(LinkedList<T> head)
        {
            var slow = head;
            var fast = head;

            while (slow is not null && fast is not null && fast.Next is not null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
