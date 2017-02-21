using System;

namespace FirstPracticeSession.LeetCode
{
    public class LengthOfLastWord
    {
        public void Main()
        {
            
        }

        public int LengthOfLastWordMethod(string s)
        {
            //Another alternate solution
            //return s.Trim().Length - s.Trim().LastIndexOf(" ") - 1;

            if (string.IsNullOrWhiteSpace(s))
                return 0;
            
            var strs = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return strs[strs.Length - 1].Length;

            
        }
    }
}
