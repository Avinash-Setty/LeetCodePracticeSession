using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays/
    /// </summary>
    public class InterectionOfTwoArrays
    {
        public void Main()
        {
            
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null)
                return new int[0];

            if(nums1.Length == 0 || nums2.Length == 0)
                return new int[0];

            var dict1 = ConvertToLookUp(nums1);
            var dict2 = ConvertToLookUp(nums2);
            var list = new List<int>();
            foreach (var key in dict1.Keys)
            {
                if(dict2.ContainsKey(key))
                    list.Add(key);
            }

            return list.ToArray();
        }

        private Dictionary<int, int> ConvertToLookUp(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            return dict;
        }
    }
}
