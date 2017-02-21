using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class ExcelSheetColumnTitle
    {
        public void Main()
        {
            Console.WriteLine(ConvertToTitle(52));
        }

        public string ConvertToTitle(int n)
        {
            var output = string.Empty;
            while (n != 0)
            {
                n--;
                output += (char)('A' + n%26);
                n = n/26;
            }

            
            return string.Join("", output.Reverse());
        }
    }
}
