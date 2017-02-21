using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// 
    /// </summary>
    public class ArithmeticSeries
    {
        public void Main()
        {
            Console.WriteLine(GetNumberOfArithmeticSlices(new[] { 1, 2, 3, 4 }));
        }

        public int GetNumberOfArithmeticSlices(int[] A)
        {
            int curr = 0, sum = 0;
            for (int i = 2; i < A.Length; i++)
                if (A[i] - A[i - 1] == A[i - 1] - A[i - 2])
                {
                    curr += 1;
                    sum += curr;
                }
                else
                {
                    curr = 0;
                }
            return sum;
        }
    }
}
