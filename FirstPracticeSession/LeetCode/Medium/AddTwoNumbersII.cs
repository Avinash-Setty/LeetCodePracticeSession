using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class AddTwoNumbersII
    {
        public void Main()
        {
            var result = AddTwoNumbers(
                new ListNode(7) {next = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3)}}},
                new ListNode(5) {next = new ListNode(6) {next = new ListNode(4)}});
            result.Display();
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();
            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            };

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            var sum = 0;
            var list = new ListNode(0);
            while (s1.Count != 0 || s2.Count != 0)
            {
                if (s1.Count != 0) sum += s1.Pop();
                if (s2.Count != 0) sum += s2.Pop();
                list.val = sum % 10;
                var head = new ListNode(sum / 10);
                head.next = list;
                list = head;
                sum /= 10;
            }

            return list.val == 0 ? list.next : list;
        }
    }
}
