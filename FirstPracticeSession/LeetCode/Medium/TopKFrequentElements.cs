using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class TopKFrequentElements
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", TopKFrequent(new [] {1,1,1,2,2,3}, 2)));
        }

        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var lookUp = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (lookUp.ContainsKey(num))
                    lookUp[num]++;
                else
                    lookUp[num] = 1;
            }

            var tuples = new List<Tuple<int, int>>();
            foreach (var i in lookUp)
            {
                tuples.Add(new Tuple<int, int>(i.Key, i.Value));
            }

            return tuples.OrderByDescending(t => t.Item2).Select(j => j.Item1).Take(k).ToList();
        }
    }
}
