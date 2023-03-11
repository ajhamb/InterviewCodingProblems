using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class Trees
    {

        public string BFSTraversal<T>(BinaryTreeNode<T> binaryTreeNode)
        {
            if (binaryTreeNode == null) return string.Empty;

            StringBuilder sb = new StringBuilder();

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(binaryTreeNode);

            while (queue.Count > 0)
            {
                BinaryTreeNode<T> node = queue.Dequeue();
                sb.Append(node.Data.ToString()).Append(",");

                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if(node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return sb.ToString();

        }

        public bool IsBalancedBinaryTree<T>(BinaryTreeNode<T> root)
        {
            int heightLeftTree = GetTreeHeight(root.Left);
            int heightRightTree = GetTreeHeight(root.Right);

            return Math.Abs(heightLeftTree - heightRightTree) <= 1 &&
                   (root.Left == null || IsBalancedBinaryTree<T>(root.Left)) &&
                   (root.Right == null || IsBalancedBinaryTree<T>(root.Right));

        }

        private int GetTreeHeight<T>(BinaryTreeNode<T> treeNode)
        {
            if (treeNode == null) return 0;
            return 1 + Math.Max(GetTreeHeight<T>(treeNode.Left), GetTreeHeight<T>(treeNode.Right));

        }
    }
}
