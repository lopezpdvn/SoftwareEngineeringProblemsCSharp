using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SoftwareEngineeringProblems.Problems;

namespace SoftwareEngineeringProblems.Tests
{
    public class StackAndQueues
    {
        [Fact]
        public void TestSeveralStacks()
        {
            var nElements = 10;
            var maxStackCapacity = 3;
            var set = new SetOfStacks(maxStackCapacity);

            for(var i = 0; i < nElements; i++)
            {
                set.Push(i * 2);
            }

            Assert.True(set.stacks.Count == 4);
            Assert.True(set.stacks[3].Size == 1);
            Assert.True(set.stacks[0].Peek() == 4);
            Assert.True(set.stacks[1].Peek() == 10);
            Assert.True(set.stacks[2].Peek() == 16);
            Assert.True(set.stacks[3].Peek() == 18);

        }

        [Fact]
        public void TestPopAt()
        {
            var nElements = 10;
            var maxStackCapacity = 3;
            var set = new SetOfStacks(maxStackCapacity);

            for (var i = 0; i < nElements; i++)
            {
                set.Push(i * 2);
            }

            Assert.True(set.PopAt(1) == 10);
            Assert.True(set.stacks.Count == 3);
            Assert.True(set.stacks[0].Peek() == 4);
            Assert.True(set.stacks[1].Peek() == 12);
            Assert.True(set.stacks[2].Peek() == 18);
        }
    }
}