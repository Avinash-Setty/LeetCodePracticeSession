using System;

namespace FirstPracticeSession.LeetCode.Imp
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber/
    /// </summary>
    public class HouseRobber
    {
        public void Main()
        {
            Console.WriteLine(Rob(new []{3,9,10,12,4,10,11}));
        }

        public int Rob(int[] nums)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a = Math.Max(a + nums[i], b);
                }
                else
                {
                    b = Math.Max(a, b + nums[i]);
                }
            }

            return Math.Max(a, b);
        }
    }
}
