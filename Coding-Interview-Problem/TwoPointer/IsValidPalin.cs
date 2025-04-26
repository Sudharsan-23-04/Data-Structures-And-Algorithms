using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Interview_Problem.TwoPointer
{
    public static partial class TwoPointer
    {
        public static bool IsValidPalin(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            var left = 0;
            var right = str.Length - 1;

            while(left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                else
                {
                    left += 1;
                    right -= 1;
                }
            }

            return true;
        }
    }
}
