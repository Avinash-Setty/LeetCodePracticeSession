using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Imp
{
    public class LowestCommonAncestorInBst
    {
        public void Main()
        {
            var ex = new TreeNode().GetBinarySearchTreeExample();
            Console.WriteLine(LowestCommonAncestor(ex, ex.FindNodeInBinarySearchTree(0), 
                ex.FindNodeInBinarySearchTree(5))?.val);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while ((root.val - p.val) * (root.val - q.val) > 0)
                root = p.val < root.val ? root.left : root.right;
            return root;
        }
    }
}
