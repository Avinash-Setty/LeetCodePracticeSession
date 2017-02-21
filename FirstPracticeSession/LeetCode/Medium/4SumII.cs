using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class _4SumII
    {
        public void Main()
        {
            
        }

        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < C.Length; i++)
            {
                for (var j = 0; j < D.Length; j++)
                {
                    var sum = C[i] + D[j];
                    if (map.ContainsKey(sum))
                        map[sum] += 1;
                    else
                        map[sum] = 1;
                }
            }

            int res = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (map.ContainsKey(-1 * (A[i] + B[j])))
                        res += map[-1 * (A[i] + B[j])];
                }
            }

            return res;
        }

        private void SumCount(List<List<int>> arrays, List<int> trackIndex, Dictionary<int, int> sumLookup)
        {
            int targetArray = 0;
            int targetSum = 0;
            for (int i = 0; i < trackIndex.Count; i++)
            {
                if (trackIndex[i] == -1)
                    targetArray = i;
                else
                    targetSum += arrays[i][trackIndex[i]];

            }

            for (int i = 0; i < trackIndex.Count; i++)
            {
                var final = targetSum + arrays[targetArray][i];
                if (sumLookup.ContainsKey(final))
                    sumLookup[final] += 1;
                else
                    sumLookup[final] = 1;
            }

            
        }
    }
}
