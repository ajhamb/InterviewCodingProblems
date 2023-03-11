using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice.Graphs
{
    public class GraphNode<T>
    {
        public T Data { get; set; }
        public List<GraphNode<T>> Neighbors { get; set; }

        public bool IsVisited { get; set; }

        public GraphNode(T data)
        {
            Data = data;
            IsVisited = false;
            Neighbors = new List<GraphNode<T>>();
        }
    }
}
