using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static InterviewPractice.DynamicProgramming.DPProblems;

namespace InterviewPracticeUnitTest.DynamicProgramming
{
    public class DPProblemsTest
    {

        [Fact]
        public void StairStepsPermutationsBottomUpandTopDownMemoizationTest()
        {
            int result1 = StairStepsPermutationsBottomUp(10);
            int result2 = StairStepsPermutationsTopDownMemoization(10, null);
            int result3 = StairStepsPermutationsBottomUpMemoizationGeneric(10, new[] {1, 2, 3});
            int result4 = StairStepsPermutationsBottomUpMemoizationGeneric(10, new[] { 1, 3, 5 });

            Assert.True(result1 == result2);

        }

        [Fact]
        public void GetRobotPathTest()
        {
            int[][] matrix = new int[][]
            {
                new int[] {1, 1, 1, 0, 0},
                new int[] {1, 1, 1, 0, 1},
                new int[] {1, 1, 0, 1, 1},
                new int[] {1, 1, 0, 0, 1},
                new int[] {1, 0, 1, 1, 1},
                new int[] {1, 1, 1, 1, 1}
            };

            var path = GetRobotPath(matrix);
        }
    }
}
