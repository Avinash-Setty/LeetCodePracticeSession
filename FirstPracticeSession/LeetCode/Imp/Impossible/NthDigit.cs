using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class NthDigit
    {
        public void Main()
        {
            Console.WriteLine(FindNthDigit(212));
        }

        public int FindNthDigit(int n)
        {
            int len = 1;
            long count = 9;
            int start = 1;

            while (n > len * count)
            {
                n -= len * (int)count;
                len += 1;
                count *= 10;
                start *= 10;
            }

            start += (n - 1) / len;
            var s = start.ToString();
            return (int)char.GetNumericValue(s[(n - 1) % len]);
        }
    }
}
