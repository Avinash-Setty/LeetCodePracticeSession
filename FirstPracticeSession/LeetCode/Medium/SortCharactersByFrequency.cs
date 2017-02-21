using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class SortCharactersByFrequency
    {
        public void Main()
        {
            Console.WriteLine(FrequencySort2("tree"));
        }

        public string FrequencySort2(string s)
        {
            if (s.Length < 3)
                return s;
            var max = 0;
            var map = new int[256];
            foreach (var ch in s)
            {
                map[ch]++;
                max = Math.Max(max, map[ch]);
            }

            var buckets = new string[max + 1]; // create max buckets
            for (var i = 0; i < 256; i++)
            { 
                // join chars in the same bucket
                var str = buckets[map[i]];
                if (map[i] > 0)
                    buckets[map[i]] = (str == null) ? "" + (char)i : (str + (char)i);
            }

            var strb = new StringBuilder();
            for (var i = max; i >= 0; i--)
            { 
                // create string for each bucket.
                if (buckets[i] != null)
                    foreach (char ch in buckets[i])
                        for (int j = 0; j < i; j++)
                            strb.Append(ch);
            }
            return strb.ToString();
        }

        public string FrequencySort(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            var dict = new Dictionary<char, int>();
            var max = int.MinValue;
            foreach (var c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                    if (dict[c] > max)
                        max = dict[c];
                }
                else
                    dict[c] = 1;
            }

            var arrary = new List<char>[max + 1];
            foreach (var key in dict.Keys)
            {
                if (arrary[dict[key]] == null)
                {
                    arrary[dict[key]] = new List<char> {key};
                }
                else
                {
                    arrary[dict[key]].Add(key);
                }
            }
            
            var output = string.Empty;
            for (int i = arrary.Length - 1; i > -1; i--)
            {
                if(arrary[i] == null)
                    continue;

                for (int j = 0; j < arrary[i].Count; j++)
                {
                    for (int x = 0; x < i; x++)
                    {
                        output += arrary[i][j];
                    }
                }
                
            }

            return output;
        }
    }
}
