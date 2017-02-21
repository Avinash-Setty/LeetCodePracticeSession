using System;
using System.Collections.Generic;
using System.Linq;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    public class MaxDepthOfBinaryTree
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

            Console.WriteLine(MaxDepth(testTree));
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var depths = new List<int>();
            FindDepth(root, depths, 0);
            return depths.Max();
        }

        private void FindDepth(TreeNode root, List<int> depths, int currentDepth)
        {
            currentDepth++;
            if (root.left == null && root.right == null)
            {
                depths.Add(currentDepth);
                return;
            }

            if (root.right != null)
            {
                FindDepth(root.right, depths, currentDepth);
            }

            if (root.left != null)
            {
                FindDepth(root.left, depths, currentDepth);
            }
        }
    }
}
