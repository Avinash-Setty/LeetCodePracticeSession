using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class NumberOfSegmentsInString
    {
        public void Main()
        {
            Console.WriteLine(CountSegments("Hello, my name is John"));
        }

        public int CountSegments(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            char prev = s[0];
            var res = 0;
            if (s[0] != ' ')
                res++;

            foreach (var alpa in s)
            {
                if (prev == ' ' && alpa != ' ')
                    res++;

                prev = alpa;
            }

            return res;
        }
    }
}
