namespace Coding_Interview_Problem.HashMapAndSets
{
    public static partial class HashMapAndSets
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i += 1)
            {

                if (dict.TryGetValue(target - nums[i], out var res))
                {
                    return [res, i];
                }
                else
                {
                    dict.TryAdd(nums[i], i);
                }
            }
            return [-1, -1];
        }
    }
}
