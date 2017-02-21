using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Models
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }

        public TreeNode()
        {
        }

        /// <summary>
        /// (Left)--(root)--(right)
        /// (less)--(middle)--(large)
        /// </summary>
        /// <returns></returns>
        public TreeNode GetBinarySearchTreeExample()
        {
            var testTree = new TreeNode(6)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(3),
                        right = new TreeNode(5)
                    }
                },

                right = new TreeNode(8)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(9)
                }
            };

            return testTree;
        }

        public TreeNode FindNodeInBinarySearchTree(int wantedVal)
        {
            var temp = this;
            while (temp.val != wantedVal)
            {
                temp = (wantedVal < temp.val) ? temp.left : temp.right;
                if (temp == null)
                    return null;
            }

            return temp;
        }

        public TreeNode ConstructTreeNodes(List<int?> values)
        {
            var root = new TreeNode();
            var index = 0;
            var count = 1;
            var listOfNodes = new List<TreeNode>();
            var nextNodes = new List<TreeNode>();
            while (index < values.Count)
            {
                var innerIndex = 0;
                for (var i = 0; i < count; i++)
                {
                    if (count == 1 && values[index].HasValue)
                    {
                        root.val = values[index].Value;
                        index++;
                        nextNodes.Add(root);
                    }
                    else if(i < values.Count && innerIndex < listOfNodes.Count)
                    {
                        if (i%2 == 0)
                        {
                            if (values[index].HasValue && listOfNodes[innerIndex] != null)
                            {
                                var leftChild = new TreeNode(values[index].Value);
                                listOfNodes[innerIndex].left = leftChild;
                                nextNodes.Add(leftChild);
                            }
                            else if(listOfNodes[innerIndex] != null)
                            {
                                listOfNodes[innerIndex].left = null;
                                nextNodes.Add(null);
                            }
                            
                            index++;
                        }
                        else
                        {
                            if (values[index].HasValue && listOfNodes[innerIndex] != null)
                            {
                                var rightChild = new TreeNode(values[index].Value);
                                listOfNodes[innerIndex].right = rightChild;
                                nextNodes.Add(rightChild);
                            }
                            else if (listOfNodes[innerIndex] != null)
                            {
                                listOfNodes[innerIndex].right = null;
                                nextNodes.Add(null);
                            }
                            index++;
                            innerIndex++;
                        }
                    }
                }

                listOfNodes.Clear();
                listOfNodes.AddRange(nextNodes);
                nextNodes.Clear();
                count = count*2;
            }

            return root;
        }
    }
}
