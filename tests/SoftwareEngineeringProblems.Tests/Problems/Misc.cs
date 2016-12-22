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
            var daStr = new List<string>();
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
            var ans = new string[] {"zero", "two", "three", "four"};
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

        [Fact]
        public void TestIteratorLowLevelString()
        {
            var daStr = new List<string>();
            daStr.Add("one");
            daStr.Add("three");
            daStr.Insert(0, "zero");
            daStr.Insert(2, "two");
            daStr.Add("four");
            var aStr = daStr.ToArray();
            var j = 0;
            for(var i = daStr.GetEnumerator(); i.MoveNext();) {
                var x = i.Current;
                Assert.Equal(x, aStr[j++]);
            }
            j = 0;
            var k = daStr.GetEnumerator();
            while(k.MoveNext())
            {
                var x = k.Current;
                Assert.Equal(x, aStr[j++]);
            }
        }

        [Fact]
        public void TestLinkedList0()
        {
            var x = new LinkedList<string>();
            x.AddLast("one");
            x.AddFirst("zero");
            x.AddLast("four");
            x.AddAfter(x.First.Next, "two");
            x.AddBefore(x.Last, "three");
            var ans = new string[] {"zero", "one", "two", "three", "four"};
            var i = 0;
            foreach(var s in x)
            {
                Assert.Equal(s, ans[i++]);
            }
            Assert.Equal(x.Count, 5);
            Assert.True(x.Contains("three"));
            var node2Remove = x.Last.Previous;
            x.Remove(node2Remove);
            Assert.False(x.Contains("three"));
            Assert.Equal(x.Count, 4);
            Assert.False(x.Contains("cuatro"));
            x.Last.Value = "cuatro";
            Assert.True(x.Contains("cuatro"));
        }
    }
}
