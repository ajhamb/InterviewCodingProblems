using System;
using System.Collections.Generic;

namespace InterviewPractice
{
    public class LinkedListInt : LinkedListBase<int>
    {
        
        public LinkedListInt(LinkedListNode<int> head): base(head)
        {            
        }

        public LinkedListInt(List<int> data):base(LinkedListHelper.InitiateLinkedList(data))
        {
        }       
        

        public LinkedListNode<int> PartitionAroundX(int partitionNumber)
        {
            return Head;
        }       


    }  
}
