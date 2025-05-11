namespace Coding_Interview_Problem.SlidingWindow
{
    public static partial class SubstringAnagram
    {
        public static int CharacterReplacement(string s, int k)
        {
            var dict = new Dictionary<char, int>();

            int left = 0;
            int maxFreq = 0;
            int result = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];

                if (!dict.ContainsKey(currentChar))
                    dict[currentChar] = 0;

                dict[currentChar]++;
                maxFreq = Math.Max(maxFreq, dict[currentChar]);

                // If more than k characters need to be replaced, shrink window
                int windowSize = right - left + 1;
                if (windowSize - maxFreq > k)
                {
                    dict[s[left]]--;
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }

            return result;
        }
    }
}
