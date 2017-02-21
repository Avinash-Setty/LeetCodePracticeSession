using System;
using System.Collections.Generic;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Imp
{
    public class PathSum
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

            Console.WriteLine(PathSumMethod(testTree, 6));
        }

        public int PathSumMethod(TreeNode root, int sum)
        {
            var preSum = new Dictionary<int, int> {{0, 1}};
            Helper(root, 0, sum, preSum);
            return _count;
        }

        private int _count;
        public void Helper(TreeNode root, int sum, int target, Dictionary<int, int> preSum)
        {
            if (root == null)
                return;

            sum += root.val;

            if (preSum.ContainsKey(sum - target))
                _count += preSum[sum - target];

            if (!preSum.ContainsKey(sum))
                preSum.Add(sum, 1);
            else
                preSum[sum] = preSum[sum] + 1;

            Helper(root.left, sum, target, preSum);
            Helper(root.right, sum, target, preSum);
            preSum[sum] = preSum[sum] - 1;
        }
    }
}
