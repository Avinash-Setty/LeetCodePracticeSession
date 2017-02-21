using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class MinimumMovesToEqualArrayElementsII
    {
        public void Main()
        {
            Console.WriteLine(MinMoves2(new []{1,2,3}));
        }

        public int MinMoves2(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            Array.Sort(nums);
            int medianIndex = nums.Length/2;
            int median = nums[medianIndex];
            int sum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                sum += Math.Abs(median - nums[j]);
            }

            return sum;
        }
    }
}
