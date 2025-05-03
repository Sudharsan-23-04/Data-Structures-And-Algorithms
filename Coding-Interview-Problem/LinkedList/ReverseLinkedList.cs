namespace Coding_Interview_Problem.LinkedList
{
    public static partial class LinkedList
    {
        public static LinkedList<T> ReverseList<T>(LinkedList<T> head)
        {
            var curNode = head;
            LinkedList<T>? prevNode = null;
            while (curNode is not null)
            {
                var nextNode = curNode.Next;
                curNode.Next = prevNode;
                prevNode = curNode;
                curNode = nextNode;
            }

            return prevNode;
        }
    }
}
