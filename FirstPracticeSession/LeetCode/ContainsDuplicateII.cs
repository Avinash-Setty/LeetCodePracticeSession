using System;
using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode
{
    public class ContainsDuplicateII
    {
        public void Main()
        {
            Console.WriteLine(ContainsNearbyDuplicate(new [] {1,0,1,1}, 1));
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
                return false;

            var dict = new Dictionary<int, int>();
            for (var index = 0; index < nums.Length; index++)
            {
                if (dict.ContainsKey(nums[index]))
                {
                    if (index - dict[nums[index]] <= k)
                        return true;

                    dict[nums[index]] = index;
                }
                else
                {
                    dict[nums[index]] = index;
                }
            }

            return false;
        }
    }
}
