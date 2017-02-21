using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class PowerOFThree
    {
        public void Main()
        {
            Console.WriteLine(IsPowerOfFour(8));
        }

        
        public bool IsPowerOfFour(int num)
        {
            // 0000 0000 0101 0101 0101 0101 0101 0101 0101 0101 check whether there is any 1 present in odd position
            // if there are any, return false
            return (num > 0) && ((num & (num - 1)) == 0) && ((num & 0x55555555) == num);
        }

        public bool IsPowerOfThree(int n)
        {
            if (n == 0)
                return false;

            if (n == 1 || n == 3)
                return true;

            var remaining = n;
            while (remaining != 1)
            {
                if (remaining%3 != 0)
                    return false;

                remaining = remaining/3;
            }

            return true;
            /*  In O(1) 
                int const Max3PowerInt = 1162261467; // 3^19, 3^20 = 3486784401 > MaxInt32
                int const MaxInt32 = 2,147,483,647; // 2^31 - 1
                bool isPowerOfThree(int n) {
                    if (n <= 0 || n > Max3PowerInt) return false;
                    return Max3PowerInt % n == 0;
                }*/

            //var str = n.ToString();
            //var sum = 0;
            //foreach (var digit in str)
            //{
            //    sum += digit - '0';
            //}

            //if (sum%9 == 0)
            //    return true;

            //return false;
        }

        public bool IsPowerOfTwo(int n)
        {
            var max2PowerInt = 1073741824; // 2^30, 2^31 = 2147483648 > MaxInt32
            var maxInt32 = 2147483647; // 2^31 - 1
            if (n <= 0 || n > max2PowerInt) return false;
            return max2PowerInt % n == 0;
        }
    }
}
