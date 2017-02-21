using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class AddStrings
    {
        public void Main()
        {
            Console.WriteLine(AddStringsMethod("123000099","123"));
        }

        public string AddStringsMethod(string num1, string num2)
        {
            var carryOver = 0;
            var arrayOfDigits = new List<char>();
            for (int i = num1.Length - 1,j = num2.Length - 1; i > -1 || j > -1; i--,j--)
            {
                var first = (i > -1) ? num1[i] - '0' : 0;
                var second = (j > -1) ? num2[j] - '0' : 0;
                var sum = first + second + carryOver;
                var sumStr = sum.ToString();
                carryOver = sumStr.Length == 2 ? sumStr[0] - '0' : 0;
                arrayOfDigits.Add(sumStr.Length == 2 ? sumStr[1]: sumStr[0]);
            }
            if(carryOver != 0)
                arrayOfDigits.Add(carryOver.ToString()[0]);

            arrayOfDigits.Reverse();
            var result = new StringBuilder();
            arrayOfDigits.ForEach(d => result.Append(d));
            return result.ToString();
        }


    }
}
