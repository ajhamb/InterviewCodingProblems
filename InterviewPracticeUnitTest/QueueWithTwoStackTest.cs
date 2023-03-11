using System;
using InterviewPractice;
using Xunit;

namespace InterviewPracticeUnitTest
{
    
    public class QueueWithTwoStackTest
    {
        [Fact]
        public void QueueWithTwoStacksTest()
        {
            QueueWithTwoStacks<int> queueWithTwoStacks = new QueueWithTwoStacks<int>();

            queueWithTwoStacks.Enqueue(1);
            queueWithTwoStacks.Enqueue(2);
            queueWithTwoStacks.Enqueue(3);
            int data = queueWithTwoStacks.Dequeue();
            queueWithTwoStacks.Enqueue(4);
            queueWithTwoStacks.Enqueue(5);
            data = queueWithTwoStacks.Dequeue();
            data = queueWithTwoStacks.Dequeue();
            data = queueWithTwoStacks.Dequeue();

            Assert.True(data == 4);
        }

    }
}
