using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    public class IsomorphicStrings
    {
        public void Main()
        {
            Console.WriteLine(IsIsomorphicStrings("foo", "bar"));
        }

        public bool IsIsomorphicStrings(string s, string t)
        {
            var m1 = new int[256];
            var m2 = new int[256];
            var n = s.Length;
            for (var i = 0; i < n; ++i)
            {
                if (m1[s[i]] != m2[t[i]]) return false;
                m1[s[i]] = i + 1;
                m2[t[i]] = i + 1;
            }
            return true;
        }
    }
}
