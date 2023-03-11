using System;
using System.Collections.Generic;
using System.Text;
using InterviewPractice;
using Xunit;

namespace InterviewPracticeUnitTest
{
    public class TreesTest
    {

        [Fact]
        public void IsBalancedBinaryTreeTest()
        {
            BinaryTreeNode<int> root = TreesHelper.InitializeTree(new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9});
            string temp = new Trees().BFSTraversal(root);

            var result = new Trees().IsBalancedBinaryTree(root);



            Assert.True(result);
        }
        
        
    }
}
