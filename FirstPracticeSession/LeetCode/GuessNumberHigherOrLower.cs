using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class GuessNumberHigherOrLower
    {
        public void Main()
        {
            Console.WriteLine(guessNumber(2126753390));
        }

        public int guessNumber(int n)
        {
            var ans = binarySearch(1, (ulong)n);
            return (int)ans;
        }

        private ulong binarySearch(ulong start, ulong end)
        {
            var mid = (end + start) /2;
            int result = guess((int)mid);

            if (result == 0)
            {
                return mid;
            }
            else if(result == 1)
            {
                return binarySearch(mid + 1, end);
            }
            else 
            {
                return binarySearch(start, mid);
            }
        }

        private int guess(int myNum)
        {
            int questionNum = 1702766719;
            if (myNum > questionNum)
            {
                return -1;
            }
            else if (myNum < questionNum)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
