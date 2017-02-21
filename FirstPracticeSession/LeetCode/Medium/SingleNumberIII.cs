using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/single-number-iii/
    /// </summary>
    public class SingleNumberIII
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", SingleNumber(new [] { 1, 2, 1, 3, 2, 5 })));
        }

        public int[] SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, bool>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict.Remove(num);
                }
                else
                {
                    dict.Add(num, true);
                }
            }

            return dict.Keys.ToArray();
        }
    }
}
