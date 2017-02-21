using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/contest/leetcode-weekly-contest-16a/problems/find-permutation/
    /// </summary>
    public class FindPermutation
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", FindPermutationMethod2("DDIIDI")));
        }

        public int[] FindPermutationMethod2(string s)
        {
            if (s == null) return new int[] { };
            int n = s.Length + 1;

            int[] res = new int[n];
            for (int i = 1; i <= n; i++)
            {
                res[i - 1] = i;
            }

            int lasti = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    reverse(res, lasti, i);
                    lasti = i + 1;

                }
            }
            reverse(res, lasti, s.Length);

            return res;
        }

        public static void reverse(int[] res, int s, int e)
        {
            // TODO Auto-generated method stub

            while (s < e)
            {
                var temp = res[s];
                res[s] = res[e];
                res[e] = temp;
                s++;
                e--;
            }
        }

        public int[] FindPermutationMethod(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return new int[0];

            var result = new int[s.Length + 1];
            int start = s.Length;
            int next = s.Length;
            int min = start;
            int max = start;
            result[0] = start;
            int index = 1;
            foreach (var letter in s)
            {
                switch (letter)
                {
                    case 'D':
                        result[index] = --next;
                        break;
                    case 'I':
                        result[index] = ++max;
                        next++;
                        break;
                }
                
                index++;
                if (next < min)
                    min = next;

                if (next > max)
                    max = next;
            }

            if (min == 1)
                return result;

            for (int i = 0; i < result.Length; i++)
            {
                result[i] -= (min - 1);
            }

            return result;
        }
    }
}
