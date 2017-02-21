using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/binary-watch/ 
    /// </summary>
    public class BinaryWatch
    {
        public void Main()
        {
            //var res = new List<string>();
            //Dfs(n, 0, 0, 0, res);
            //return res;
        }

        private void Dfs(int n, int hours , int mins , int idx, List<string> res)
        {
            //if (hours >= 12 || mins > 59)
            //    return;

            //if(n > 0)
            //    res.Add($"{hours}:+ "0" * (mins < 10) + str(mins))
            //    return
            //for i in range(idx, 10):
            //    if i < 4: 
            //        Dfs(n - 1, hours | (1 << i), mins, i + 1)
            //    else:
            //        k = i - 4
            //        Dfs(n - 1, hours, mins | (1 << k), i + 1)
        }
            


        
    }
}
