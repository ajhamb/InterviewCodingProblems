using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewPracticeUnitTest.SearchAndSorting
{
    public class SearchAlgoTest
    {

        [Fact]
        public void BinarySearchTest()
        {
            int[] data = new[] {2, 3, 5, 7, 9, 33, 55, 66, 77};
            int element = 7;

            int result = InterviewPractice.SearchAndSorting.SearchAlgo.BinarySearch(data, element);

            Assert.True(result == 3);
        }
    }
}
