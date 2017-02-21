using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-cycle/
    /// </summary>
    public class LinkedListCycle
    {
        public void Main()
        {
            var loop = new ListNode(1) {next = new ListNode(2)};
            var loop1 = new ListNode(3) {next = loop};
            loop.next.next = loop1;
            Console.WriteLine(HasCycle(loop));
        }

        public bool HasCycle(ListNode head)
        {
            var oneJump = head;
            var twoJump = head?.next;
            while (oneJump != null && twoJump != null)
            {
                if (oneJump.val == twoJump.val)
                    return true;

                oneJump = oneJump.next;
                twoJump = twoJump.next?.next;
            }

            return false;
        }
    }
}
