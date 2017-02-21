using System;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Imp
{
    public class LowestCommonAncestorInBinaryTree
    {
        public void Main()
        {
            var testTree = new TreeNode().GetBinarySearchTreeExample();
            Console.WriteLine(FindLcaInBt(testTree, testTree.FindNodeInBinarySearchTree(0), 
                testTree.FindNodeInBinarySearchTree(5))?.val.ToString() ?? "NULL");
        }

        public TreeNode FindLcaInBt(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q) return root;
            TreeNode left = FindLcaInBt(root.left, p, q);
            TreeNode right = FindLcaInBt(root.right, p, q);
            return left == null ? right : right == null ? left : root;
        }
    }
}
