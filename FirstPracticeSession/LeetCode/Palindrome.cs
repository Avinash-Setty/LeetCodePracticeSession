using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class Palindrome
    {
        public void Main()
        {
            Console.WriteLine(IsPalindrome(12521));
        }

        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            for (int start = 0, end = str.Length - 1; start <= end; start++,end--)
            {
                if (str[start] != str[end])
                    return false;
            }

            return true;
        }
    }
}
