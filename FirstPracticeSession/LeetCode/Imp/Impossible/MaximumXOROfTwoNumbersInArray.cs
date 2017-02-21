using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class MaximumXOROfTwoNumbersInArray
    {
        public void Main()
        {
            Console.WriteLine(findMaximumXOR(new [] { 3, 10, 5, 25, 2, 8 }));
        }

        class Trie
        {
            public Trie[] children;
            public Trie()
            {
                children = new Trie[2];
            }
        }

        public int findMaximumXOR(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            // Init Trie.
            Trie root = new Trie();
            foreach (int num in nums)
            {
                Trie curNode = root;
                for (int i = 31; i >= 0; i--)
                {
                    int curBit = (num >> i) & 1;
                    if (curNode.children[curBit] == null)
                    {
                        curNode.children[curBit] = new Trie();
                    }
                    curNode = curNode.children[curBit];
                }
            }

            int max = int.MinValue;
            foreach (int num in nums)
            {
                Trie curNode = root;
                int curSum = 0;
                for (int i = 31; i >= 0; i--)
                {
                    int curBit = (num >> i) & 1;
                    if (curNode.children[curBit ^ 1] != null)
                    {
                        curSum += (1 << i);
                        curNode = curNode.children[curBit ^ 1];
                    }
                    else
                    {
                        curNode = curNode.children[curBit];
                    }
                }
                max = Math.Max(curSum, max);
            }
            return max;
        }
    }
}
