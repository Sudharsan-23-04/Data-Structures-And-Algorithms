namespace Coding_Interview_Problem.TwoPointer
{
    public static partial class TwoPointer
    {
        //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        public static int[] TwoSumSorted(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                var sum = numbers[left] + numbers[right];
                if (target == sum)
                {
                    return [left + 1, right + 1];
                }
                else if (sum > target)
                {
                    right -= 1;
                }
                else if (sum < target)
                {
                    left += 1;
                }
            }
            return [];
        }
    }
}