using System;
using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/excel-sheet-column-number
    /// </summary>
    public class ExcelSheetColumnNumber
    {
        public void Main()
        {
            Console.WriteLine(TitleToNumber("AAA"));
        }

        public int TitleToNumber(string s)
        {
            var lookup = new Dictionary<char,int>();
            for (int i = 0; i < 26; i++)
            {
                lookup.Add((char) (65+i), i+1);
            }

            // AB -> 26(A) + B
            // AAA -> 26((26)A + A) + A
            // AAAA ->  26(26((26)A + A)A + A) + A
            var sum = 0;
            var index = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                sum += (int)Math.Pow(26, index) * lookup[s[i]];
                index++;
            }

            return sum;
        }
    }
}
