using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class FindAllDuplicatesInAnArray
    {
        public void Main()
        {
            
        }

        public IList<int> FindDuplicates(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict[nums[i]] = 1;
            }

            return dict.Keys.Where(k => dict[k] == 2).ToList();
        }
    }
}
