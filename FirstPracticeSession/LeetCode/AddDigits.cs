using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class AddDigits
    {
        public void Main()
        {
            Console.WriteLine(AddDigitsMethod(3145));
        }

        public int AddDigitsMethod(int num)
        {
            var n = num.ToString();
            if (n.Length < 2)
                return num;

            var sum = 0;
            while (n.Length > 1)
            {
                sum = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    sum += int.Parse(n[i].ToString());
                }
                n = sum.ToString();
            }

            return sum;
        }
    }
}
