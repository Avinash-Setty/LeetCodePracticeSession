using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/count-primes/
    /// </summary>
    public class CountPrimes
    {
        public void Main()
        {
            Console.WriteLine(CountPrimesMethod3(499979));
        }

        public int CountPrimesMethod(int n)
        {
            if (n <= 1)
                return 0;

            var list = new List<int>();
            for (int i = 2; i < n; i++)
            {
                list.Add(i);
            }

            var divisible = 2;
            while (divisible < n)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if(divisible == list[i])
                        continue;

                    if (list[i]%divisible == 0)
                    {
                        list.RemoveAt(i);
                    }
                }

                divisible++;
            }

            return list.Count;
        }

        public int CountPrimesMethod2(int n)
        {
            var count = 0;
            for (var i = 1; i < n; i++)
            {
                if (isPrime(i)) count++;
            }

            return count;
        }

        private bool isPrime(int num)
        {
            if (num <= 1) return false;

            // Loop's ending condition is i * i <= num instead of i <= sqrt(num)
            // to avoid repeatedly calling an expensive function sqrt().
            for (var i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        private int CountPrimesMethod3(int n)
        {
            bool[] notPrime = new bool[n];
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (notPrime[i] == false)
                {
                    count++;
                    for (int j = 2; i * j < n; j++)
                    {
                        notPrime[i * j] = true;
                    }
                }
            }

            return count;
        }
    }
}
