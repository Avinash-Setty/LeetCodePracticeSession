using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Imp
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-linked-list/
    /// </summary>
    public class PalindromeLinkedList
    {
        public void Main()
        {
            Console.WriteLine(IsPalindrome(new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(2) {next = new ListNode(1)} } } }));
        }

        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;

            var slow = head;
            var fast = head;
            var stack = new Stack<int>();
            while (fast != null)
            {
                stack.Push(slow.val);
                if (fast.next != null)
                {
                    slow = slow.next;
                }

                fast = fast.next?.next;
            }

            while (slow != null)
            {
                var poppped = stack.Pop();
                if (poppped != slow.val)
                    return false;

                slow = slow.next;
            }

            return true;
        }
    }
}
