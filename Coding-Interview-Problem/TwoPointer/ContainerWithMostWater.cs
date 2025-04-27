using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Interview_Problem.TwoPointer
{
    public static partial class TwoPointer
    {
        //https://leetcode.com/problems/container-with-most-water/
        public static int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var max_water = -1;
            while (left < right)
            {
                var cur_max = Math.Min(height[left], height[right]) * (right - left);
                max_water = Math.Max(max_water, cur_max);
                if (height[left] > height[right])
                {
                    right -= 1;
                }
                else if (height[left] < height[right])
                {
                    left += 1;
                }
                else
                {
                    left += 1;
                    right -= 1;
                }
            }
            return max_water;
        }
    }
}
