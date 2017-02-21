using System;
using System.Collections.Generic;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Imp
{
    /// <summary>
    /// https://leetcode.com/problems/balanced-binary-tree
    /// </summary>
    public class BalancedTree
    {
        public void Main()
        {
            var testTree = new TreeNode().ConstructTreeNodes(new List<int?> {1,3,3,null,null,2,null});
            Console.WriteLine(IsBalanced(testTree));
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            var leftHeight = FindDepth(root.left);
            var rightHeight = FindDepth(root.right);
            if (Math.Abs(leftHeight - rightHeight) > 1)
                return false;

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        public int FindDepth(TreeNode node)
        {
            if (node == null)
                return 0;

            var leftDepth = FindDepth(node.left) + 1;
            var rightDepth = FindDepth(node.right) + 1;
            return Math.Max(leftDepth, rightDepth);
        }
    }
}
