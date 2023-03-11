using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class TreesHelper
    {
        public static BinaryTreeNode<T> InitializeTree<T>(List<T> dataList)
        {
            BinaryTreeNode<T> root = new BinaryTreeNode<T>();
            root.Data = dataList[0];
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            int index = 1;

            while(queue.Count > 0)
            {
                BinaryTreeNode<T> binaryTreeNode = queue.Dequeue();
                
                if (index < dataList.Count)
                {
                    binaryTreeNode.Left = new BinaryTreeNode<T>();
                    binaryTreeNode.Left.Data = dataList[index++];
                    queue.Enqueue(binaryTreeNode.Left);
                }

                if (index + 1 < dataList.Count)
                {
                    binaryTreeNode.Right = new BinaryTreeNode<T>();
                    binaryTreeNode.Right.Data = dataList[index++];
                    queue.Enqueue(binaryTreeNode.Right);
                }

            }

            return root;
        }
    }
}
