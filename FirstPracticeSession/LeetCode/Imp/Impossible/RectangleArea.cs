using System;

namespace FirstPracticeSession.LeetCode.Imp
{
    /// <summary>
    /// https://leetcode.com/problems/rectangle-area/
    /// </summary>
    public class RectangleArea
    {
        public void Main()
        {
            Console.WriteLine(ComputeArea(-3,0,3,4,0,-1,9,2));
        }

        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            int left = Math.Max(A, E);

            //TODO: Couldnt figure out this logic
            int right = Math.Max(Math.Min(C, G), left);
            int bottom = Math.Max(B, F);

            //TODO: Couldnt figure out this logic
            int top = Math.Max(Math.Min(D, H), bottom);
            return (C - A) * (D - B) - (right - left) * (top - bottom) + (G - E) * (H - F);
        }
    }
}
