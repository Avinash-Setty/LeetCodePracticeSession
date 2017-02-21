using System;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/count-and-say/
    /// </summary>
    public class CountAndSay
    {
        public void Main()
        {
            Console.WriteLine(CountAndSayMethod(4));
        }

        public string CountAndSayMethod(int n)
        {
            if (n == 1)
                return "1";

            return GenerateCountAndSay(n, "1");
        }

        private string GenerateCountAndSay(int n, string current)
        {
            if (n == 1)
                return current;

            var count = 0;
            var currentChar = current[0];
            var index = 0;
            var currentSay = string.Empty;
            while (index < current.Length)
            {
                if (currentChar == current[index])
                {
                    count++;
                }
                else
                {
                    currentSay += $"{count}{currentChar}";
                    count = 1;
                    currentChar = current[index];
                }

                index++;
            }

            currentSay += $"{count}{currentChar}";
            return GenerateCountAndSay(n - 1, currentSay);
        }
    }
}
