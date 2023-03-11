using System;
using System.Collections.Generic;
using System.Text;
using InterviewPractice;
using Xunit;

namespace InterviewPracticeUnitTest
{
   public class ArrayStringTest
    {
        [Fact]
        public void FindAllPermutationsTest()
        {
            NumIdenticalPairs(new int[] {1, 2, 3, 1, 1, 3});

            string data = "ABCD";

            var permutations = ArrayStringTester.FindAllPermutations(data, 0);

            Assert.True(permutations.Count == 24);
        }

        public int NumIdenticalPairs(int[] nums)
        {

            Dictionary<int, int> numCount = new Dictionary<int, int>();
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numCount.ContainsKey(nums[i]))
                    numCount.Add(nums[i], 0);
                numCount[nums[i]]++;
            }

            foreach (var pair in numCount)
            {
                int value = pair.Value;
                total = total + (value * value - 1) / 2;

            }

            return total;

        }
    }
}
