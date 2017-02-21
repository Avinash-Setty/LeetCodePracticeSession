using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/first-unique-character-in-a-string/
    /// </summary>
    public class FirstUniqueCharInString
    {
        public void Main()
        {
            
        }

        public int FirstUniqChar(string s)
        {
            var lookUp = new Dictionary<char, int>();
            foreach (var letter in s)
            {
                if (lookUp.ContainsKey(letter))
                    lookUp[letter]++;
                else
                    lookUp[letter] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (lookUp[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
