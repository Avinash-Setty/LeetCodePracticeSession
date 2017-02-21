using System;
using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-boomerangs/
    /// </summary>
    public class Boomerangs
    {
        public void Main()
        {
            Console.WriteLine(FindTheBoomerangs(new int[,] {{0, 0}, {1, 0}, {2, 0}}));
        }

        public int FindTheBoomerangs(int[,] points)
        {
            var res = 0;
            for (var index = 0; index < points.Length / 2; index++)
            {
                var lookUp = new Dictionary<double, int>();
                for (var reindex = 0; reindex < points.Length / 2; reindex++)
                {
                    if (reindex == index)
                        continue;

                    var d = Math.Sqrt(Math.Pow(points[reindex, 0] - points[index, 0], 2) + Math.Pow(points[reindex, 1] - points[index, 1], 2));
                    if (lookUp.ContainsKey(d))
                        lookUp[d]++;
                    else
                        lookUp[d] = 1;
                }
                
                foreach (var value in lookUp.Values)
                    res += value * (value - 1);

                lookUp.Clear();
            }

            return res;
        }
    }
}
