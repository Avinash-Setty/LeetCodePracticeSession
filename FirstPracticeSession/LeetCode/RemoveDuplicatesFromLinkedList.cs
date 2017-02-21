using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    public class RemoveDuplicatesFromLinkedList
    {
        public void Main()
        {
            var node = new ListNode(1) { next = new ListNode(2) { next = new ListNode(2) { next = new ListNode(4) } } };
            node.Display();
            DeleteDuplicates(node).Display();
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;

            var newHead = head;
            var prev = newHead;
            var temp = newHead.next;
            while (temp != null)
            {
                if (prev.val == temp.val)
                {
                    prev.next = temp.next;
                }
                else
                {
                    prev = temp;
                }

                temp = temp.next;
            }

            return newHead;
        }
    }
}
