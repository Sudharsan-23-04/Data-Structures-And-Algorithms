namespace Coding_Interview_Problem.LinkedList
{
    public static partial class LinkedList
    {
        public static LinkedList<T> GetIntersectionNode<T>(LinkedList<T> headA, LinkedList<T> headB)
        {
            var pointerA = headA;
            var pointerB = headB;

            while (pointerA != pointerB)
            {
                pointerA = pointerA is null ? headB : pointerA.Next;
                pointerB = pointerB is null ? headA : pointerB.Next;
            }

            return pointerA;
        }
    }
}
