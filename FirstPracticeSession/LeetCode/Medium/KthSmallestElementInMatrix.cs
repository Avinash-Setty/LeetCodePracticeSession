using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class KthSmallestElementInMatrix
    {
        public void Main()
        {
            Console.WriteLine(KthSmallest(new int[3,3] {{ 1, 5, 9}, {10, 11, 13}, { 12, 13, 15}}, 8));
            //Console.WriteLine(KthSmallest(new int[,] { {-5} }, 1));
        }

        public int KthSmallest(int[,] matrix, int k)
        {
            int previousNumber = int.MaxValue;
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    k--;
                    if (k == 0)
                        return matrix[x, y];
                }
            }

            return 0;
        }
    }
}
