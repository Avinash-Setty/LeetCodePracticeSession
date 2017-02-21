using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one
    /// </summary>
    public class PlusOne
    {
        public void Main()
        {
            Console.WriteLine(string.Join("",AddOne(new []{9,9,9,9,9,9})));
        }

        private int[] AddOne(int[] digits)
        {
            if (digits.Length == 0)
                return new int[] {};

            if(digits[0] == 0)
                return new [] {1};

            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1]++;
                return digits;
            }

            var list = new List<int>();
            list.AddRange(digits);
            var incrementOnce = false;
            for (var index = list.Count - 1; index >= 0; index--)
            {
                if (list[index] == 9)
                {
                    list[index] = 0;
                    incrementOnce = true;
                }
                else if(incrementOnce) 
                {
                    list[index]++;
                    break;
                }
            }

            if (list[0] == 0)
            {
                var newList = new List<int> {1};
                newList.AddRange(list);
                return newList.ToArray();
            }

            return list.ToArray();
        }
    }
}
