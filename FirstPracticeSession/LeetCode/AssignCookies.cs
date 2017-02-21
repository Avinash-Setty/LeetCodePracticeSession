using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class AssignCookies
    {
        public void Main()
        {
            Console.WriteLine(FindContentChildren(new [] {1,2,3,1,4}, new []{1,2,3,4}));
        }

        public int FindContentChildren(int[] g, int[] s)
        {
            var sortedG = g.ToList();
            sortedG.Sort();
            var sortedS = s.ToList();
            sortedS.Sort();

            var cookieTempIndex = 0;
            var numberOfCookies = sortedS.Count;
            var numberOfContentChild = 0;
            for (var childIndex = 0; childIndex < sortedG.Count; childIndex++)
            {
                for (var cookieIndex = cookieTempIndex; cookieIndex < numberOfCookies; cookieIndex++)
                {
                    if (sortedG[childIndex] <= sortedS[cookieIndex])
                    {
                        cookieTempIndex = cookieIndex + 1;
                        numberOfContentChild++;
                        break;
                    }
                }

            }

            return numberOfContentChild;
        }
    }
}
