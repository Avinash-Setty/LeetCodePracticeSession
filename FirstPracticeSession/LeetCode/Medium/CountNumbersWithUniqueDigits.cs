using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class CountNumbersWithUniqueDigits
    {
        public void Main()
        {
            Console.WriteLine(CountNumbersWithUniqueDigitsMethod(100));
        }

        public int CountNumbersWithUniqueDigitsMethod(int n)
        {
            if (n == 0)
                return 1;

            int ans = 10, initial = 9;
            for (int i = 2; i <= n && i <= 10; i++)
            {
                initial = initial * (9 - i + 2);
                ans += initial;
            }

            return ans;
        }
    }
}
