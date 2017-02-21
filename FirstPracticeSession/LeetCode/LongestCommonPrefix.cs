using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix
    /// </summary>
    public class LongestCommonPrefix
    {
        public void Main()
        {
            Console.WriteLine(LongestCommonPrefixMethod(new[] {"aaa", "aa", "a"}));
        }

        public string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            var firstStr = strs[0];
            if (strs.Length == 1)
                return firstStr;

            var letterIndex = 0;
            var commonPrefix = "";
            foreach (var letter in firstStr)
            {
                var index = 1;
                while (index < strs.Length)
                {
                    if (letterIndex > strs[index].Length - 1 || strs[index][letterIndex] != letter)
                        return commonPrefix;

                    index++;
                }

                commonPrefix += letter;
                letterIndex++;
            }

            return commonPrefix;
        }
    }
}
