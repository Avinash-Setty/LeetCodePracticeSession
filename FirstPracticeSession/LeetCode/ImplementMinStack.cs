using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/min-stack/
    /// </summary>
    public class ImplementMinStack
    {
        public void Main()
        {
            
        }

        public class MinStack
        {

            /** initialize your data structure here. */

            List<int> nums = new List<int>();
            private int min = int.MaxValue;
            public MinStack()
            {

            }

            public void Push(int x)
            {
                nums.Add(x);
                if (min > x)
                    min = x;
            }

            public void Pop()
            {
                if(nums.Count == 0)
                    return;

                nums.RemoveAt(nums.Count - 1);
                min = nums.Min();
            }

            public int Top()
            {
                if (nums.Count == 0)
                    return 0;

                return nums[nums.Count - 1];
            }

            public int GetMin()
            {
                return min;
            }
        }
    }
}
