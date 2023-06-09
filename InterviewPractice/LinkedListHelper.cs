﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public static class LinkedListHelper
    {
        public const string LINK = "-->";

        public static LinkedListNode<int> InitiateLinkedList(List<int> list)
        {
            LinkedListNode<int> head = null;
            LinkedListNode<int> prev = null;

            foreach (var v in list)
            {
                var node = new LinkedListNode<int>(v, null);
                head ??= node;

                if (prev != null) prev.Next = node;

                prev = node;

            }

            return head;

        }

        internal static string Display<T>(LinkedListNode<T> head)
        {
            if (head == null || head.Next == null) return null;

            
            StringBuilder sb = new StringBuilder();

            while(head!=null)
            {
                sb.Append(head.Data.ToString()).Append(LINK);
                head = head.Next;
            }

            return sb.ToString(0, sb.Length - LINK.Length - 1);
        }

        internal static string PrintReverse<T>(LinkedListNode<T> current)
        {

            if (current.Next == null) return current.Data.ToString();
            string ret = PrintReverse(current.Next);
            return ret + LINK + current.Data;
        }
    }


}
