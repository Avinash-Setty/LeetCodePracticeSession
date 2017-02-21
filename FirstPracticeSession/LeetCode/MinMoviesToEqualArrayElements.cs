using System;
using System.Linq;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-moves-to-equal-array-elements/
    /// </summary>
    public class MinMoviesToEqualArrayElements
    {
        public void Main()
        {
            Console.WriteLine(MinMoves(new[] {1,2,3}));
        }

        public int MinMoves(int[] nums)
        {
            var min = nums.ToList().Min();
            var moves = 0;
            nums.ToList().ForEach(n =>
            {
                moves = moves + Math.Abs(min - n);
            });
            return moves;
        }
    }
}
