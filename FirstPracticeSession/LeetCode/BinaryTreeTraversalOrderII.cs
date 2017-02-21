using System;
using System.Collections.Generic;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
    /// </summary>
    public class BinaryTreeTraversalOrderII
    {
        public void Main()
        {
            var result = LevelOrderBottom(new TreeNode().GetBinarySearchTreeExample());
            foreach (var list in result)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {   
            var rows = new List<IList<int>>();
            if (root == null)
                return rows;

            UpToBottom(new List<TreeNode> {root}, rows);
            rows.Reverse();
            return rows;
        }

        public void UpToBottom(IList<TreeNode> nodes, IList<IList<int>> rows)
        {
            var row = new List<int>();
            var nextNodes = new List<TreeNode>();
            foreach (var treeNode in nodes)
            {
                row.Add(treeNode.val);
                if(treeNode.left != null)
                    nextNodes.Add(treeNode.left);

                if(treeNode.right != null)
                    nextNodes.Add(treeNode.right);
            }

            rows.Add(row);
            if (nextNodes.Count == 0)
                return;

            UpToBottom(nextNodes, rows);
        }
    }
}
