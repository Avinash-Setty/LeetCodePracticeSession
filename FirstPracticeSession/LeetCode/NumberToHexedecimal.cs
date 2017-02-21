using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class NumberToHexedecimal
    {
        public void Main()
        {
            Console.WriteLine(ToHexWhichAlsoHandlesNegative(26));
        }

        private string ToHexWhichAlsoHandlesNegative(int input)
        {
            if (input == 0)
                return "0";

            long n = input & 0x00000000ffffffffL;
            var lookUp = new Dictionary<double, string>
            {
                {0, "0"}, { 1, "1" }, { 2, "2" }, { 3, "3" }, { 4, "4" },
                {5, "5"},{6, "6"},{7, "7"},{8, "8"},{9, "9"},
                {10, "a"},{11, "b"},{12, "c"},{13, "d"},{14, "e"},{15, "f"},
            };
            var temp = n;
            var result = string.Empty;
            while (temp != 0)
            {
                result = lookUp[temp&15] + result;
                temp = temp >> 4;
            }

            return result;
        }

        /// <summary>
        /// One solution
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ToHex(int input)
        {
            var builder = new StringBuilder();
            ConvertToHex(input, builder);
            return builder.ToString();
        }

        public void ConvertToHex(int input, StringBuilder output)
        {
            if(input <= 0)
                return;

            int rank = 0;
            while (Math.Floor(input / Math.Pow(16, rank)) > 16)
            {
                rank++;
            }

            var nextInput = input%Math.Pow(16, rank);
            output.Append(Convert(Math.Floor(input/Math.Pow(16, rank))));
            ConvertToHex((int)nextInput, output);
        }

        public string Convert(double number)
        {
            var lookUp = new Dictionary<double, string>
            {
                {0, "0"}, { 1, "1" }, { 2, "2" }, { 3, "3" }, { 4, "4" },
                {5, "5"},{6, "6"},{7, "7"},{8, "8"},{9, "9"},
                {10, "a"},{11, "b"},{12, "c"},{13, "d"},{14, "e"},{15, "f"},
            };
            return lookUp[number];
        }
    }
}
