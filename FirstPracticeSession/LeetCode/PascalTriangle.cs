using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle
    /// </summary>
    public class PascalTriangle
    {
        public void Main()
        {
            var result = Generate(10);
            int index = 1;
            foreach (var list in result)
            {
                Console.WriteLine($"({index}) -> " + string.Join(",", list));
                index++;
            }
        }

        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            var rowCount = 1;
            var row = new List<int>();
            var previousRow = new List<int>();
            while (rowCount <= numRows)
            {
                var digitIndex = 0;
                row = new List<int>();
                while (digitIndex < rowCount)
                {
                    if (digitIndex == 0)
                    {
                        row.Add(1);
                    }
                    else if (digitIndex == rowCount - 1)
                    {
                        row.Add(1);    
                    }
                    else
                    {
                        var digit = previousRow[digitIndex - 1] + previousRow[digitIndex];
                        row.Add(digit);
                    }

                    digitIndex++;
                }

                result.Add(row);
                previousRow.Clear();
                previousRow.AddRange(row);
                rowCount++;
            }


            return result;
        }
    }
}
