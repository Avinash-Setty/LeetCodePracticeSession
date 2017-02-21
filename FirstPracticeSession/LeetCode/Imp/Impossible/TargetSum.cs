using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/contest/leetcode-weekly-contest-16a/problems/target-sum/
    /// </summary>
    public class TargetSum
    {
        public void Main()
        {
            Console.WriteLine(FindTargetSumWays(new int[] {1,1,1,1}, 2));
        }

        public int FindTargetSumWays(int[] nums, int s)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] += nums[i];
            }

            return sum < s ? 0 : SubsetSum(nums, s + sum);
        }

        public int SubsetSum(int[] nums, int s)
        {
            int n = nums.Length;
            var dp = new int[s + 1,n + 1];
            dp[0,0] = 1;
            for (int i = 0; i <= s; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    dp[i,j] = dp[i,j - 1];
                    if (i - nums[j - 1] >= 0)
                        dp[i,j] += dp[i - nums[j - 1],j - 1];
                }
            }
                   
            return dp[s,n];
        }    
    }
}
