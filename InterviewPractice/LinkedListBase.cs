using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public abstract class LinkedListBase<T>
    {
        public LinkedListNode<T> Head { get; set; }
        protected LinkedListBase(LinkedListNode<T> node) 
        {
            Head = node;
        }

        public void RemoveDuplicatesWithHashet()
        {
            if (Head == null) return;

            LinkedListNode<T> current = Head;
            var hashSet = new HashSet<T>();

            while (current != null)
            {
                if (!hashSet.Contains(current.Data))
                {
                    hashSet.Add(current.Data);
                    current = current.Next;
                }
                else
                {
                    DeleteNode(current);
                }
            }
        }

        public string Display() => Head.Display;

        public bool DeleteNode(T data)
        {
            return DeleteNode(FindNode(data));
        }

        public bool DeleteNode(LinkedListNode<T> node)
        {
            if (node == null || node.Next == null) return true;

            LinkedListNode<T> next = node.Next;
            node.Data = next.Data;
            node.Next = next.Next;

            return true;
        }
        private LinkedListNode<T> FindNode(T data)
        {
            if (Head == null || Head.Next == null) return null;

            LinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data)) return current;
                current = current.Next;
            }

            return null;
        }
    }
}
