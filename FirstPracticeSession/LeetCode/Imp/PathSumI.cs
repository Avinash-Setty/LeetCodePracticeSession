using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum/
    /// </summary>
    public class PathSumI
    {
        public void Main()
        {
            Console.WriteLine(HasPathSum(new TreeNode().ConstructTreeNodes(new List<int?> { 5,4,8,11,null,13,4,7,2, null, null,null, null,null,1}), 22));
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            var result = TraverseTree(root, sum, 0);
            return result;
        }

        private bool TraverseTree(TreeNode node, int sum, int currentSum)
        {
            currentSum += node.val;
            if (node.left == null && node.right == null)
            {
                return sum == currentSum;
            }
            
            var left = false;
            if (node.left != null)
                left = TraverseTree(node.left, sum, currentSum);

            var right = false;
            if(node.right != null && !left)
                right = TraverseTree(node.right, sum, currentSum);

            return left || right;
        }
    }
}
