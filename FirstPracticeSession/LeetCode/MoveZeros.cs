using System;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// </summary>
    public class MoveZeros
    {
        public void Main()
        {
            var nums = new[] {1,0,1,0,2,3};
            MoveZeroes(nums);
            Console.WriteLine(string.Join(",", nums));
        }

        public void MoveZeroes(int[] nums)
        {
            var numberOfZeroes = 0;
            for (var index = 0; index < nums.Length; index++)
            {
                if (nums[index] == 0)
                {
                    numberOfZeroes++;
                    continue;
                }

                var moveIndex = index;
                for (var move = 1; move <= numberOfZeroes; move++)
                {
                    nums[index - move] = nums[moveIndex];
                    nums[moveIndex] = 0;
                    moveIndex--;
                }
            }
        }
    }
}
