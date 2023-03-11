using System.Collections.Generic;

namespace InterviewPractice
{
    public class LinkedListProblems
    {
        public static LinkedListNode<int> AddTwoListsReverse(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {           

            if (list1 == null && list2 == null) return null;
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            LinkedListNode<int> head = null;
            LinkedListNode<int> current = null;

            int carry = 0;

            while(list1 != null || list2 != null)
            {

                int number = (list1 == null ? 0 : list1.Data) + (list2 == null ? 0 : list2.Data) + carry;
                

                LinkedListNode<int> node = new LinkedListNode<int>(number % 10 , null);
                if (head == null) head = node;

                if (current != null) current.Next = node;

                current = node;
                carry = number / 10;

                if (list1 != null) list1 = list1.Next;
                if (list2 != null) list2 = list2.Next;
            }

            if(carry > 0)
            {
                LinkedListNode<int> node = new LinkedListNode<int>(carry, null);
                current.Next = node;
            }
            

            return head;
        }
    }
}
