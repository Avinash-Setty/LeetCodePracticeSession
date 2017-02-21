using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class IntegerBreak
    {
        public void Main()
        {
            Console.WriteLine(IntegerBreakMethod(10));
        }

        public int IntegerBreakMethod(int n)
        {
            if (n == 2) return 1;
            if (n == 3) return 2;
            int product = 1;
            while (n > 4)
            {
                product *= 3;
                n -= 3;
            }
            product *= n;

            return product;
        }
    }
}
