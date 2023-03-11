using InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterviewPracticeUnitTest
{
    public class LinkedListIntTest
    {
        [Fact]
        public void LinkedListIntTest_RemoveDuplicatesWithHashset()
        {
            LinkedListInt linkedListIntSource = new LinkedListInt(new List<int> { 1, 2, 3, 4, 5, 5, 6, 7 });
            LinkedListInt linkedListIntTarget = new LinkedListInt(new List<int> { 1, 2, 3, 4, 5, 6, 7 });

            linkedListIntSource.RemoveDuplicatesWithHashet();

            //var display = linkedListInt.Display();

            Assert.True(linkedListIntSource != null);
            //Assert.True(display.Equals("1-->2-->3-->4-->5-->6-->7"));
            Assert.True(linkedListIntSource.Display().Equals(linkedListIntTarget.Display()));

        }

    }
}
