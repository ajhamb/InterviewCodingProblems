using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class QueueWithTwoStacks<T>
    {

        private readonly Stack<T> _stackOld = new Stack<T>();
        private readonly Stack<T> _stackNew = new Stack<T>();

        public void Enqueue(T data)
        {
            _stackOld.Push(data);
        }

        public T Dequeue()
        {
            if (_stackNew.Count > 0) return _stackNew.Pop();

            while (_stackOld.Count != 1)
            {
                _stackNew.Push(_stackOld.Pop());
            }

            return _stackOld.Pop();
        }
    }
}
