using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class FactorialTrailingZeroes
    {
        public void Main()
        {
            for (int i = 1; i < 25; i++)
            {
                Console.WriteLine($"Number: {i} and Fact: {Factorial(i)} and TrailingZeroes:{TrailingZeroes(i)}");
            }
        }

        private double Factorial(int numberInt)
        {
            int result = numberInt;
            for (int i = 1; i < numberInt; i++)
            {
                result = result * i;
            }

            return result;
        }

        public int TrailingZeroes(int n)
        {
            double zeros = 0;
            double current = 1;
            var k = 1;
            while (current >= 1)
            {
                current = Math.Truncate(n/Math.Pow(5, k));
                zeros += current;
                k++;
            }

            return (int) zeros;
        }
    }
}
