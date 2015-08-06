using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SoftwareEngineeringProblems.Tests
{
    public class Program
    {
        public void Main(string[] args)
        {
        }
    }

    public class ClassTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4,  Class1.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Class1.Add(2, 2));
        }

    }
}
