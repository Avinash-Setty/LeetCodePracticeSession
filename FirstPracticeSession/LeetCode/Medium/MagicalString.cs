using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class MagicalString
    {
        public void Main()
        {
            Console.WriteLine(FindOnesInMagicalString(10));
        }

        public int FindOnesInMagicalString(int n)
        {
            if (n <= 0) return 0;
            if (n <= 3) return 1;

            var a = new int[n + 1];
            a[0] = 1; a[1] = 2; a[2] = 2;
            int head = 2, tail = 3, num = 1, result = 1;

            while (tail < n)
            {
                for (var i = 0; i < a[head]; i++)
                {
                    a[tail] = num;
                    if (num == 1 && tail < n) result++;
                    tail++;
                }
                num = num ^ 3;
                head++;
            }

            return result;
        }
    }
}
