using System;
using System.Collections.Generic;
using Xunit;

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

            //Assert.True(false);
        }
    }

    public class CollectionMisc
    {
        [Fact]
        public void TestDynamicArrayList()
        {
            List<string> daStr = new List<string>();
            daStr.Add("one");
            daStr.Add("three");
            daStr.Insert(0, "zero");
            daStr.Insert(2, "two");
            daStr.Add("four");
            Assert.Equal(daStr.Count, 5);
            Assert.True(daStr.Contains("one"));
            daStr.RemoveAt(1);
            Assert.False(daStr.Contains("one"));
            Assert.Equal(daStr[1], "two");
            Assert.Equal(daStr.IndexOf("three"), 2);
            Assert.Equal(daStr.Count, 4);
            string[] ans = new string[] {"zero", "two", "three", "four"};
            var i = 0;
            foreach(var str in daStr) {
                Assert.Equal(ans[i++], str);
            }
            daStr[1] = "dos";
            ans = new string[] {"zero", "dos", "three", "four"};
            i = 0;
            foreach(var str in daStr) {
                Assert.Equal(ans[i++], str);
            }
        }
    }
}
