using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class MergeTwoSortedLists
    {
        public void Main()
        {
            var node1 = new ListNode(1) { next = new ListNode(4) { next = new ListNode(9) { next = new ListNode(10) } } };
            var node2 = new ListNode(2) { next = new ListNode(3) { next = new ListNode(6) { next = new ListNode(11) } } };
            var result = MergeTwoLists(node1, node2);
            result.Display();
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l2.next, l1);
                return l2;
            }
        }
    }
}
