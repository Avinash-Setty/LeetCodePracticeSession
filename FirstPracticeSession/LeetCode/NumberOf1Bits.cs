using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class NumberOf1Bits
    {
        public void Main()
        {
            Console.WriteLine(HammingWeight(2));
        }

        public int HammingWeight(uint n)
        {
            uint ones = 0;
            while (n != 0)
            {
                ones = ones + (n & 1);
                n = n >> 1;
            }
            return (int)ones;
        }
    }
}
