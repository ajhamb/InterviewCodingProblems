using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Prev { get; set; }

        public string Display
        {
            get
            {
                return LinkedListHelper.Display(this);
            }
        }

        public LinkedListNode(T data, LinkedListNode<T> next, LinkedListNode<T> prev = null)
        {
            Data = data;
            Next = next;
            this.Prev = prev;
        }
      
    }
}