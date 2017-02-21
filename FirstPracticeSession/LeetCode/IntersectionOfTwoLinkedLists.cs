using System;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-linked-lists
    /// </summary>
    public class IntersectionOfTwoLinkedLists
    {
        public void Main()
        {
            var commonNode = new ListNode(3) {next = new ListNode(4)};
            var result = GetIntersectionNode(
                new ListNode(1) {next = new ListNode(2) {next = commonNode}},
                new ListNode(-1) {next = new ListNode(-2) {next = new ListNode(-3) {next = commonNode}}});
            Console.WriteLine(result.val);
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var la = GetLength(headA);
            var lb = GetLength(headB);
            if (la > lb)
                return GetCommonNode(headA, headB, la - lb);

            return GetCommonNode(headB, headA, lb - la);
        }

        private ListNode GetCommonNode(ListNode longer, ListNode smaller, int diff)
        {
            while (diff != 0)
            {
                longer = longer.next;
                diff--;
            }

            var tempa = longer;
            var tempb = smaller;
            while (tempb != null && tempa != null)
            {
                if (tempb.val == tempa.val)
                    return tempb;

                tempb = tempb.next;
                tempa = tempa.next;
            }

            return null;
        }

        private int GetLength(ListNode head)
        {
            int length = 0;
            var temp = head;
            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            return length;
        }

    }
}
