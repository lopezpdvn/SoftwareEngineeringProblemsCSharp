using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SoftwareEngineeringProblems;

namespace SoftwareEngineeringProblems.Tests
{
    public class Misc
    {
        [Fact]
        public void TestEnumerablesViaIterators()
        {
            var genericCol = new AnIntGenericCollection();
            foreach(var i in genericCol)
            {
                Console.WriteLine(i);
            }

            var nonGenericCol = new AnIntCollection();
            foreach (var i in nonGenericCol)
            {
                Console.WriteLine((int)i);
            }

            Assert.True(false);
        }
    }
}
