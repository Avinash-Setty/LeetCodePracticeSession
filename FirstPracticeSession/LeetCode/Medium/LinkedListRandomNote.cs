using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class LinkedListRandomNote
    {
        public void Main()
        {
            var obj = new Solution(new ListNode(2) {next = new ListNode(4) {next = new ListNode(5)} });
            var random1 = obj.GetRandom();
            Console.WriteLine(random1);
        }

        public class Solution
        {
            public ListNode Head { get; set; }
            public int Length { get; set; }
            public Random HelpeRandom { get; set; }

            public Solution(ListNode head)
            {
                Head = head;
                while (head != null)
                {
                    Length++;
                    head = head.next;
                }

                HelpeRandom = new Random();
            }

            /** Returns a random node's value. */
            public int GetRandom()
            {
                var randomLength = HelpeRandom.Next(1, Length + 1);
                var temp = Head;
                while (randomLength > 1)
                {
                    temp = temp.next;
                    randomLength--;
                }

                return temp.val;
            }
        }
    }
}
