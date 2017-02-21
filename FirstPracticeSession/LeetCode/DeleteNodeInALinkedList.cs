using System;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    public class DeleteNodeInALinkedList
    {
        public void Main()
        {
            var nodeToDelete = new ListNode(3) {next = new ListNode(4)};
            var node = new ListNode(1) {next = new ListNode(2) {next = nodeToDelete } };
            var nodeToDiplay = node;
            while (nodeToDiplay != null)
            {
                Console.Write($"-> {nodeToDiplay.val} ");
                nodeToDiplay = nodeToDiplay.next;
            }

            DeleteNode(nodeToDelete);
            nodeToDiplay = node;
            Console.WriteLine();
            Console.WriteLine($"After Delete {nodeToDelete.val}");
            while (nodeToDiplay != null)
            {
                Console.Write($"-> {nodeToDiplay.val} ");
                nodeToDiplay = nodeToDiplay.next;
            }
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
