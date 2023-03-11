using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public T Data { get; set; }
    }
}
