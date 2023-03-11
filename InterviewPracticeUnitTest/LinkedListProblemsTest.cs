using InterviewPractice;
using System.Collections.Generic;
using Xunit;

namespace InterviewPracticeUnitTest
{
    public class LinkedListProblemsTest
    {

        [Fact]
        public void TestLinkedListProblems_AddTwoLists()
        {
            InterviewPractice.LinkedListNode<int> result = LinkedListProblems.AddTwoListsReverse(new LinkedListInt(new List<int> { 7, 1, 9, 9 }).Head, new LinkedListInt(new List<int> { 5, 9 }).Head);

            Assert.True(result.Data == 2);


        }



    }
}
