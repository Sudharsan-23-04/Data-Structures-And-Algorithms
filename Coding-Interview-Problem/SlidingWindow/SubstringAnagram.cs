namespace Coding_Interview_Problem.SlidingWindow
{
    public static partial class SubstringAnagram
    {
        //https://leetcode.com/problems/find-all-anagrams-in-a-string/description/
        public static IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            if (s.Length < p.Length) return result;

            var expectedFreq = new int[26];
            var windowFreq = new int[26];

            foreach (char c in p)
            {
                expectedFreq[c - 'a']++;
            }

            int left = 0, right = 0;
            while (right < s.Length)
            {
                windowFreq[s[right] - 'a']++;

                if (right - left + 1 > p.Length)
                {
                    windowFreq[s[left] - 'a']--;
                    left++;
                }

                if (right - left + 1 == p.Length)
                {
                    if (windowFreq.SequenceEqual(expectedFreq))
                    {
                        result.Add(left);
                    }
                }

                right++;
            }

            return result;
        }
    }
}
