using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/fizz-buzz
    /// </summary>
    public class FizzBizz
    {
        public IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    list.Add("FizzBuzz");
                    continue;
                }

                if (i%3 == 0)
                {
                    list.Add("Fizz");
                    continue;
                }

                if (i%5 == 0)
                {
                    list.Add("Buzz");
                    continue;
                }

                list.Add(i.ToString());
            }

            return list;
        }
    }
}
