using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPracticeSession.LeetCode.Models;

namespace FirstPracticeSession.LeetCode
{
    public class BinaryTreePaths
    {
        public void Main()
        {
            BinaryTreePathsMethod(new TreeNode().ConstructTreeNodes(new List<int?> {1, 2, 3, 4, 5, null, 6}));
        }

        public IList<string> BinaryTreePathsMethod(TreeNode root)
        {
            var paths = new List<string>();
            if (root == null)
                return paths;

            TraverseTree(root, paths, string.Empty);
            return paths;
        }

        private void TraverseTree(TreeNode root, List<string> paths, string path)
        {
            if (root.left == null && root.right == null)
            {
                path += $"{root.val}";
                paths.Add(path);
                return;
            }

            path += $"{root.val}->";
            if (root.left != null)
                TraverseTree(root.left, paths, path);

            if (root.right != null)
                TraverseTree(root.right, paths, path);
        }
    }
}
