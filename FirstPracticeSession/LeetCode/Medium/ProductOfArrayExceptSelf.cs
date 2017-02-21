using System;

namespace FirstPracticeSession.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self
    /// </summary>
    public class ProductOfArrayExceptSelf
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", ProductExceptSelf(new [] {2,4,1,5})));
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return nums;

            int n = nums.Length;
            int[] res = new int[n];
            res[0] = 1;
            for (int i = 1; i < n; i++)
            {
                res[i] = res[i - 1] * nums[i - 1];
            }

            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                res[i] *= right;
                right *= nums[i];
            }

            return res;
        }
    }
}
