using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstPracticeSession.LeetCode
{
    public class FindTheDifference
    {
        public void Main()
        {
            Console.WriteLine(FindTheDifferenceMethod("asadrfg", "adafagrs"));
        }

        public char FindTheDifferenceMethod(string s, string t)
        {
            var lookup = new Dictionary<char,int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (!lookup.ContainsKey(t[i]))
                {
                    lookup.Add(t[i],1);
                }
                else
                {
                    lookup[t[i]]++;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (lookup.ContainsKey(s[i]))
                {
                    lookup[s[i]]--;
                    if (lookup[s[i]] == 0)
                    {
                        lookup.Remove(s[i]);
                    }
                }
            }

            return lookup.Keys.First();
        }
    }
}
