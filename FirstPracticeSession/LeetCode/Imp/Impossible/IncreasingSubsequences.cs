using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode.Imp.Impossible
{
    /// <summary>
    /// https://leetcode.com/contest/leetcode-weekly-contest-16a/problems/increasing-subsequences/
    /// </summary>
    public class IncreasingSubsequences
    {
        public void Main()
        {
            FindSubsequences(new []{ 4, 6, 7, 8 });
        }

        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            var res = new List<IList<int>>();
            Helper(res, new List<int>(), nums, 0);
            return res;
        }

        private void Helper(List<IList<int>> res, List<int> list, int[] nums, int id)
        {
            if (list.Count > 1) res.Add(new List<int>(list));
            var unique = new List<int>();
            for (var i = id; i < nums.Length; i++)
            {
                // skip non-increase
                if (id > 0 && nums[i] < nums[id - 1])
                    continue; 
                
                // skip duplicate
                if (unique.Contains(nums[i]))
                    continue; 

                unique.Add(nums[i]);
                list.Add(nums[i]);
                Helper(res, list, nums, i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
