using System;

namespace FirstPracticeSession.LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public void Main()
        {
            var nums = new[] {1, 1, 2, 2, 2, 3, 3, 4, 5, 6};
            Console.WriteLine(RemoveDuplicates(nums));
            Console.WriteLine(string.Join(",", nums));
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
                return 0;
            
            var count = 0;
            var index = 0;
            var valIndex = 0;
            var val = int.MinValue;
            while (valIndex < nums.Length)
            {
                if (nums[valIndex] == val)
                {
                    valIndex++;
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        nums[index] = nums[valIndex];
                        val = nums[valIndex];
                    }
                    else
                    {
                        val = nums[valIndex];
                    }

                    valIndex++;
                    index++;
                }
            }

            return nums.Length - count;
        }
    }
}
