using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Interview_Problem.SlidingWindow
{
    public static partial class SubstringAnagram
    {
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var left = 0;
            var right = 0;
            var hashSet = new HashSet<char>();
            var maxLength = 0;
            while (right < s.Length)
            {
                if (!hashSet.Contains(s[right]))
                {
                    hashSet.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    hashSet.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }
    }
}
