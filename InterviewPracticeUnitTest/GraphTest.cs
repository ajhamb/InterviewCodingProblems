using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using InterviewPractice.Graphs;
using Xunit;

namespace InterviewPracticeUnitTest
{
    public class GraphTest
    {
        [Fact]
        public void GraphBFSTest()
        {
            Graph<int> graph = GraphHelper.InitializeIntGraph();
            string result = graph.BFS();

            Assert.True(result.Length > 0);

        }

        [Fact]
        public void GraphDFSTest()
        {
            Graph<int> graph = GraphHelper.InitializeIntGraph();

            string result = graph.DFS();

            Assert.True(result.Length > 0);

        }
    }
}
