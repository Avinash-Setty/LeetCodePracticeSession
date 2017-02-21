using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class IsSubsequence
    {
        public void Main()
        {
            Console.WriteLine(IsSubsequenceMethod("aabbc", "ababcd"));
        }

        public bool IsSubsequenceMethod(string s, string t)
        {
            var lookUp = new Dictionary<char, List<int>>();
            for (int i = 0; i < t.Length; i++)
            {
                if(lookUp.ContainsKey(t[i]))
                    lookUp[t[i]].Add(i);
                else
                    lookUp[t[i]] = new List<int> {i};
            }

            var usedCharLookUp = new Dictionary<char, int>();
            int previousIndex = -1;
            foreach (var ch in s)
            {
                if (lookUp.ContainsKey(ch))
                {
                    if (!usedCharLookUp.ContainsKey(ch))
                        usedCharLookUp[ch] = 0;

                    bool found = false;
                    for (int i = usedCharLookUp[ch]; i < lookUp[ch].Count; i++)
                    {
                        if (previousIndex < lookUp[ch][i])
                        {
                            previousIndex = lookUp[ch][i];
                            usedCharLookUp[ch] = i;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        return false;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
