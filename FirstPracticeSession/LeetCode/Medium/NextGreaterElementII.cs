using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class NextGreaterElementII
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", NextGreaterElements(new [] {-2, 1, -3, 4, -1, 2, 1, -5, 4})));
        }

        public int[] NextGreaterElements(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return nums;

            var list = new List<int>();
            NextBigNumber(nums, list, 0);
            return list.ToArray();
        }

        private void NextBigNumber(int[] nums, List<int> output, int startIndex)
        {
            if (startIndex == nums.Length)
                return;
            
            var max = nums[startIndex];
            var reachedLimit = false;
            var foundIt = false;
            for (int i = startIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    foundIt = true;
                    output.Add(nums[i]);
                    break;
                }

                if (i == nums.Length - 1 && !reachedLimit)
                {
                    reachedLimit = true;
                    i = 0;
                }

                if (reachedLimit && nums[i] > max)
                {
                    foundIt = true;
                    output.Add(nums[i]);
                    break;
                }
            }

            if(!foundIt)
                output.Add(-1);

            NextBigNumber(nums, output, startIndex + 1);
        }
    }
}
