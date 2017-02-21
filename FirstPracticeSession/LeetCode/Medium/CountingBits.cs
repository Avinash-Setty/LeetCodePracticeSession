using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    /// <summary>
    /// 
    /// </summary>
    public class CountingBits
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", CountBits(32)));
        }

        private int[] CountBits(int num)
        {
            int[] ret = new int[num + 1];
            ret[0] = 0;
            int pow = 1;
            for (int i = 1, t = 0; i <= num; i++, t++)
            {
                if (i == pow)
                {
                    pow *= 2;
                    t = 0;
                }
                ret[i] = ret[t] + 1;
            }

            return ret;
        }
    }
}
