using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-immutable/
    /// </summary>
    public class RangeSumQueryImmutable
    {
        public void Main()
        {
            
        }

        public class NumArray
        {
            private readonly int[] _numbers;
            public NumArray(int[] nums)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] += nums[i - 1];
                }

                _numbers = nums;
            }

            public int SumRange(int i, int j)
            {
                if (i == 0)
                    return _numbers[j];
                
                return _numbers[j] - _numbers[i - 1];
            }
        }
    }
}
