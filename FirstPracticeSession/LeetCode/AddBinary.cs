using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary
    /// </summary>
    public class AddBinary
    {
        public void Main()
        {
            Console.WriteLine(AddBinaryMethod("111","1010"));
        }

        public string AddBinaryMethod(string a, string b)
        {
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
                return string.Empty;

            if (string.IsNullOrEmpty(a))
                return b;

            if (string.IsNullOrEmpty(b))
                return a;

            var carryOver = 0;
            var result = "";
            for (int aL = a.Length - 1,bL = b.Length - 1; aL > -1 || bL > -1; aL--,bL--)
            {
                var current = (aL > -1?(a[aL] - '0'):0) + 
                    (bL > -1?(b[bL] - '0'):0) + carryOver;
                if (current == 3)
                {
                    carryOver = 1;
                    result += 1;
                }
                else if (current == 2)
                {
                    carryOver = 1;
                    result += 0;
                }
                else if (current == 1)
                {
                    carryOver = 0;
                    result += 1;
                }
                else
                {
                    carryOver = 0;
                    result += 0;
                }
            }

            if(carryOver == 1)
                result += 1;

            return string.Join("", result.Reverse());
        }
    }
}
