using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class BinaryTreeInOrderTraversal
    {
        public void Main()
        {
            var node = new TreeNode();
            Console.WriteLine(string.Join(",", InorderTraversal(node.ConstructTreeNodes(new List<int?> { 1,null,2, null,null,3,null}))));
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            InOrder(root, result);
            return result;
        }

        private void InOrder(TreeNode node, List<int> values)
        {
            if(node == null)
                return;

            InOrder(node.left, values);
            values.Add(node.val);
            InOrder(node.right, values);
        }
    }
}
