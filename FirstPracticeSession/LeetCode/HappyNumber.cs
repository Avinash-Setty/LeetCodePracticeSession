using System;
using System.Globalization;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// </summary>
    public class HappyNumber
    {
        public void Main()
        {
            Console.WriteLine(IsHappy(82));
        }

        public bool IsHappy(int n)
        {
            var str = n.ToString();
            while (str != "1" && str != "2" && str != "3" && str != "4")
            {
                double sum = 0;
                foreach (var digit in str)
                {
                    sum += Math.Pow(digit - '0', 2);
                }

                str = sum.ToString(CultureInfo.InvariantCulture);
            }

            return str == "1";
        }
    }
}
