using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Interview_Problem.FastAndSlowPointer
{
    public static partial class FastAndSlowPointer
    {
        public static bool HasCycle<T>(LinkedList<T> head)
        {
            var slow = head;
            var fast = head;

            while (slow is not null && fast is not null && fast.Next is not null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
