using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Interview_Problem.FastAndSlowPointer
{
    public static partial class FastAndSlowPointer
    {
        public static bool IsHappy(int n)
        {
            var slow = n;
            var fast = n;
            while (true)
            {
                slow = GetNum(slow);
                fast = GetNum(GetNum(fast));

                if (fast == 1)
                {
                    return true;
                }

                if (fast == slow)
                {
                    return false;
                }
            }

        }

        private static int GetNum(int n)
        {
            var nextNum = 0;
            while (n > 0)
            {
                int digit = n % 10;

                n = n / 10;

                nextNum += digit * digit;
            }

            return nextNum;
        }
    }
}
