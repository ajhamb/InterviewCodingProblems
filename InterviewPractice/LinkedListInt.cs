using System;
using System.Collections.Generic;

namespace InterviewPractice
{
    public class LinkedListInt
    {
        public LinkedListInt(LinkedListNode<int> head)
        {
            Head = head;
            Display = LinkedListHelper.Display(Head);
        }

        public LinkedListInt(List<int> data)
        {
            Head = LinkedListHelper.InitiateLinkedList(data);
            Display = LinkedListHelper.Display(Head);
        }

        public LinkedListNode<int> Head { get; set; }
        private string Display { get; set; }

        public LinkedListNode<int> PartitionAroundX(int partitionNumber)
        {            
            return Head;
        }

        public bool DeleteNode(int data)
        {
            LinkedListNode<int> node = FindNode(data);

            if (node == null || node.Next == null) return true;

            LinkedListNode<int> next = node.Next;
            node.Data = next.Data;
            node.Next = next.Next;

            return true;
        }

        public string PrintReverse(LinkedListNode<int> current)
        {            

            if (current.Next == null) return current.Data.ToString() ;
            string ret = PrintReverse(current.Next);
            return ret + "-->" + current.Data;
        }

        private LinkedListNode<int> FindNode(int data)
        {
            if (Head == null || Head.Next == null) return null;


            LinkedListNode<int> current = Head;

            while(current != null)
            {
                if (current.Data == data) return current;
                current = current.Next;
            }

            return null;
        }
    }


  
}
