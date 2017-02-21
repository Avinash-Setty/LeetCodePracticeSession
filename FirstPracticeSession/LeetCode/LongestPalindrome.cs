using System;
using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindrome/
    /// </summary>
    public class LongestPalindrome
    {
        public void Main()
        {
            Console.WriteLine(LongestPalindromeMethod("abccccdd"));
        }

        public int LongestPalindromeMethod(string s)
        {
            var dict = new Dictionary<char, int>();
            int dups = 0;
            foreach (var letter in s)
            {
                if (dict.ContainsKey(letter))
                {
                    dict.Remove(letter);
                    dups++;
                }
                else
                {
                    dict[letter] = 1;
                }
            }

            if (dict.Count > 0)
                return dups * 2 + 1;

            return dups * 2;
        }
    }
}
