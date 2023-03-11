using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice.Graphs
{
    public static class GraphHelper
    {
        public static Graph<int> InitializeIntGraph()
        {
            GraphNode<int> node0 = new GraphNode<int>(0);
            GraphNode<int> node1 = new GraphNode<int>(1);
            GraphNode<int> node2 = new GraphNode<int>(2);
            GraphNode<int> node3 = new GraphNode<int>(3);
            GraphNode<int> node4 = new GraphNode<int>(4);
            GraphNode<int> node5 = new GraphNode<int>(5);
            GraphNode<int> node6 = new GraphNode<int>(6);
            GraphNode<int> node7 = new GraphNode<int>(7);
            GraphNode<int> node8 = new GraphNode<int>(8);

            node0.Neighbors.AddRange(new List<GraphNode<int>>() { node1, node3 });
            node1.Neighbors.AddRange(new List<GraphNode<int>>() { node0 });
            node2.Neighbors.AddRange(new List<GraphNode<int>>() { node8, node3, node0 });
            node3.Neighbors.AddRange(new List<GraphNode<int>>() { node0, node2, node4, node5 });
            node4.Neighbors.AddRange(new List<GraphNode<int>>() { node6, node3 });
            node5.Neighbors.AddRange(new List<GraphNode<int>>() { node3 });
            node6.Neighbors.AddRange(new List<GraphNode<int>>() { node7, node4 });
            node7.Neighbors.AddRange(new List<GraphNode<int>>() { node6 });
            node8.Neighbors.AddRange(new List<GraphNode<int>>() { node2 });

            Graph<int> graph = new Graph<int>();
            graph.GraphNodes.AddRange(new List<GraphNode<int>>()
                {node0, node1, node2, node3, node4, node5, node6, node7, node8});

            return graph;
        }
    }
}
