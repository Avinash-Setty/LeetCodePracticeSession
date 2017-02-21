using System;

namespace FirstPracticeSession.LeetCode.Models
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public void Display()
        {
            var nodeToDiplay = this;
            while (nodeToDiplay != null)
            {
                Console.Write($"-> {nodeToDiplay.val} ");
                nodeToDiplay = nodeToDiplay.next;
            }
        }
    }
}
