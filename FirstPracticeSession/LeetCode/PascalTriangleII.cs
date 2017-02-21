using System;
using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode
{
    public class PascalTriangleII
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", GetRow(3)));
        }

        public IList<int> GetRow(int rowIndex)
        {
            var rowCount = 1;
            var row = new List<int>();
            var previousRow = new List<int>();
            while (rowCount <= rowIndex + 1)
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

                previousRow.Clear();
                previousRow.AddRange(row);
                rowCount++;
            }

            return row;
        }
    }
}
