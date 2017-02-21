using System;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    public class ImplementstrStrMethod
    {
        public void Main()
        {
            Console.WriteLine(StrStr("mississippi", "mississippi"));
        }

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
                return 0;

            if (string.IsNullOrEmpty(needle))
                return 0;

            if (string.IsNullOrEmpty(haystack))
                return -1;

            if (needle.Length > haystack.Length)
                return -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int k = 0,j = i; k < needle.Length && j<haystack.Length; k++,j++)
                {
                    if (haystack[j] == needle[k])
                    {
                        if (k == needle.Length - 1)
                            return i;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return -1;
        }
    }
}
