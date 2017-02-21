using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/arranging-coins
    /// </summary>
    public class ArrangingCoins
    {
        public void Main()
        {
            Console.WriteLine(ArrangeCoins(8));
        }

        /// <summary>
        /// The problem is basically asking the maximum length of consecutive number that has the running sum lesser or equal to `n`. In other word, find `x` that satisfy the following condition:
        // `1 + 2 + 3 + 4 + 5 + 6 + 7 + ... + x <= n
        // sum_{i=1}^x i <= n`
        // Running sum can be simplified,
        // (x* ( x + 1)) / 2 <= n`
        // Using quadratic formula, `x` is evaluated to be,
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ArrangeCoins(int n)
        {
            int start = 0;
            int end = n;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) >> 1;
                if ((0.5 * mid * mid + 0.5 * mid) <= n)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return start - 1;
        }
    }
}
