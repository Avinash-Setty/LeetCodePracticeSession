using System;
using System.Collections.Generic;
using System.Linq;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public class MinDepthOfBinaryTree
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

            Console.WriteLine(MinDepth(testTree));
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            var left = MinDepth(root.left);
            var right = MinDepth(root.right);
            return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
        }
    }
}
