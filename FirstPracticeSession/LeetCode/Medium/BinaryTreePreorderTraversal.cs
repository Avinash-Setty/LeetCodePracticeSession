using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode.Medium
{
    public class BinaryTreePreorderTraversal
    {
        public void Main()
        {
            Console.WriteLine(string.Join(",", Preorder(new TreeNode().GetBinarySearchTreeExample())));
        }

        public IList<int> Preorder(TreeNode node)
        {
            var list = new List<int>();
            var rights = new Stack<TreeNode>();
            while (node != null)
            {
                list.Add(node.val);
                if (node.right != null)
                {
                    rights.Push(node.right);
                }
                node = node.left;
                if (node == null && rights.Count != 0)
                {
                    node = rights.Pop();
                }
            }
            return list;
        }
    }
}
