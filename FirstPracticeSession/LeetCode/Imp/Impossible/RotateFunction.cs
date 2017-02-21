using System;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-function/
    /// </summary>
    public class RotateFunction
    {
        public void Main()
        {
            Console.WriteLine(MaxRotateFunction(new [] {4,3,2,6}));
        }

        public int MaxRotateFunction(int[] A)
        {
            int allSum = 0;
            int len = A.Length;
            int F = 0;
            for (int i = 0; i < len; i++)
            {
                F += i * A[i];
                allSum += A[i];
            }
            int max = F;
            for (int i = len - 1; i >= 1; i--)
            {
                F = F + allSum - len * A[i];
                max = Math.Max(F, max);
            }
            return max;
        }
    }
}
