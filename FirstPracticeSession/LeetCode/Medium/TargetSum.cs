using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class TargetSum2
    {
        public void Main()
        {
            Console.WriteLine(FindTargetSumWays(new int[] {1,1,1,1}, 2));
        }

        public int FindTargetSumWays(int[] nums, int S)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var lookup = new Dictionary<string, int>();
            var result = Helper(nums, 0, 0, S, lookup);
            return result;
        }
        private int Helper(int[] nums, int index, int sum, int S, Dictionary<string, int> map)
        {
            var encodeString = index + "->" + sum;
            if (map.ContainsKey(encodeString))
            {
                return map[encodeString];
            }
            if (index == nums.Length)
            {
                if (sum == S)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            int curNum = nums[index];
            int add = Helper(nums, index + 1, sum - curNum, S, map);
            int minus = Helper(nums, index + 1, sum + curNum, S, map);
            map.Add(encodeString, add + minus);
            return add + minus;
        }
    }
}
