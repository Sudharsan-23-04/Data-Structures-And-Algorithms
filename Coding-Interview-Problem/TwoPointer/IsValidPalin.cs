namespace Coding_Interview_Problem.TwoPointer
{
    public static partial class TwoPointer
    {


        //https://leetcode.com/problems/valid-palindrome/
        public static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            var left = 0;
            var right = str.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(str[left]))
                {
                    left += 1;
                }
                while (left < right && !char.IsLetterOrDigit(str[right]))
                {
                    right -= 1;
                }
                if (char.ToLowerInvariant(str[left]) != char.ToLowerInvariant(str[right]))
                {
                    return false;
                }
                left += 1;
                right -= 1;
            }

            return true;
        }
    }
}
