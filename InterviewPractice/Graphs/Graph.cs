using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice.Graphs
{
    public class Graph<T>
    {
        public List<GraphNode<T>> GraphNodes = new List<GraphNode<T>>();


        public string BFS()
        {
            if (GraphNodes == null || GraphNodes.Count <= 0) return string.Empty;

            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            queue.Enqueue(GraphNodes[0]);

            StringBuilder sb = new StringBuilder();

            while (queue.Count > 0)
            {
                GraphNode<T> graphNode = queue.Dequeue();
                sb.Append(graphNode.Data.ToString()).Append(",");
                graphNode.IsVisited = true;

                foreach (GraphNode<T> graphNodeNeighbor in graphNode.Neighbors)
                {
                    if(graphNodeNeighbor.IsVisited) continue;

                    queue.Enqueue(graphNodeNeighbor);
                }
            }

            return sb.ToString();
        }

        public string DFS()
        {
            if (GraphNodes == null || GraphNodes.Count <= 0) return string.Empty;
            
            StringBuilder sb = new StringBuilder();

            foreach (GraphNode<T> graphNode in GraphNodes)
            {
                if (graphNode.IsVisited == false)
                    DFS(graphNode, sb);
            }

            return sb.ToString();
        }

        private string DFS(GraphNode<T> graphNode, StringBuilder sb)
        {
            sb.Append(graphNode.Data.ToString()).Append(",");
            graphNode.IsVisited = true;

            foreach (GraphNode<T> neighbors in graphNode.Neighbors)
            {
                if (neighbors.IsVisited == false)
                    DFS(neighbors, sb);
            }

            return sb.ToString();

        }
    }
}
