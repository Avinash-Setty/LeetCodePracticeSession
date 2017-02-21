using System;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    public class InvertBinaryTree
    {
        public void Main()
        {
            var testTree = new TreeNode(2)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(0)
                        {
                            right = new TreeNode(2)
                            {
                                left = new TreeNode(5)
                            }
                        },
                        right = new TreeNode(5)
                    }
                },

                right = new TreeNode(4)
                {
                    left = new TreeNode(2)
                }
            };

            InvertNodes(testTree);
        }

        public TreeNode InvertTree(TreeNode root)
        {
            InvertNodes(root);
            return root;
        }

        private void InvertNodes(TreeNode root)
        {
            if(root == null)
                return;

            var left = root.left;
            root.left = root.right;
            root.right = left;
            if (root.left != null)
                InvertNodes(root.left);

            if (root.right != null)
                InvertNodes(root.right);
        }
    }
}
