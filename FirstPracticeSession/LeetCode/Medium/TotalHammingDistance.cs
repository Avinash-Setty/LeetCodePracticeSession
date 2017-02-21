using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class TotalHammingDistance
    {
        public void Main()
        {
            Console.WriteLine(TotalHammingDistanceMethod2(new [] {4,14,2}));
        }

        public int TotalHammingDistanceMethod2(int[] nums)
        {
            var n = 31;
            var len = nums.Length;
            var countOfOnes = new int[n];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    countOfOnes[j] += (nums[i] >> j) & 1;
                }
            }

            var sum = 0;
            foreach (int count in countOfOnes)
            {
                sum += count * (len - count);
            }

            return sum;
        }

        public int TotalHammingDistanceMethod(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += HammingDistance(nums[i], nums[j]);
                }
            }

            return sum;
        }

        private int HammingDistance(int num1, int num2)
        {
            var num = num1 ^ num2;
            var bitCount = 0;
            while (num > 0)
            {
                var res = num & 1;
                if (res > 0)
                    bitCount++;

                num = num >> 1;
            }

            return bitCount;
        }
    }
}
