using System;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/contest/leetcode-weekly-contest-16b/problems/construct-the-rectangle/
    /// </summary>
    public class ConstructRectangle
    {
        public void Main()
        {
            Console.WriteLine(ConstructRectangleMethod(18));
        }

        public int[] ConstructRectangleMethod(int area)
        {
            if(area == 0)
                return new[] {0,0};

            int width = (int)Math.Sqrt(area);
            while (area % width != 0)
            {
                width--;
                if (width == 0)
                    return new[] {1, area};
            }

            var height = area/width;
            if (height > width)
                return new[] {height, width};

            return new[] {width, height};
        }
    }
}
