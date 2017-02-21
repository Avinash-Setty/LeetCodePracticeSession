using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-anagrams-in-a-string
    /// </summary>
    public class FindAllAnagramsInAString
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", findAnagrams("abb", "bb")));
        }

        public IList<int> findAnagrams(string s, string p)
        {
            var dict = new Dictionary<char, int>();
            var result = new List<int>();
            foreach (var character in p)
            {
                if (dict.ContainsKey(character))
                {
                    dict[character]++;
                }
                else
                {
                    dict.Add(character,1);
                }
            }

            int match = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]--;
                    if (dict[s[i]] == 0)
                        match++;
                }

                if (i >= p.Length)
                {
                    char temp = s[i - p.Length];
                    if (dict.ContainsKey(temp))
                    {
                        dict[temp]++;
                        if (dict[temp] == 1)
                            match--;
                    }
                }

                if (match == dict.Count)
                    result.Add(i-(p.Length-1));
            }

            return result;
        }


    }
}
