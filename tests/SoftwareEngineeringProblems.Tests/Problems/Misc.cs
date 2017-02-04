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
            IList<string> daStr = new List<string>();
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
            Assert.Throws<ArgumentOutOfRangeException>(() => daStr[10]);
        }

        [Fact]
        public void TestIteratorLowLevelString()
        {
            IList<string> daStr = new List<string>();
            daStr.Add("one");
            daStr.Add("three");
            daStr.Insert(0, "zero");
            daStr.Insert(2, "two");
            daStr.Add("four");
            var aStr = ((List<string>)daStr).ToArray();
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
            Assert.Equal(x.Find("two"), x.Last.Previous);
            Assert.Equal(x.FindLast("two"), x.Last.Previous);
            Assert.Equal(x.Find("xyz"), null);
            Assert.True(x.First.Next.Previous == x.First);
        }

        [Fact]
        public void TestDictionary0()
        {
            IDictionary<string, string> x = new Dictionary<string, string>();
            x["zero"] = "cero";
            x["one"] = "uno";
            x["two"] = "dos";
            Assert.Equal(x.Count, 3);
            Assert.Equal("uno", x["one"]);
            Assert.Throws<KeyNotFoundException>(() => x["ONE"]);
            x["one"] = "UNO";
            Assert.Equal("UNO", x["one"]);
            Assert.True(x.Remove("two"));
            Assert.False(x.Remove("two"));
            Assert.Equal(2, x.Count);
            string val;
            Assert.False(x.TryGetValue("two", out val));
            Assert.Equal(default(string), val);
            Assert.Equal(null, val);
            Assert.False(x.ContainsKey("two"));
            Assert.True(((Dictionary<string, string>) x).ContainsValue("UNO"));
        }

        [Fact]
        public void TestDictionaryIteration0()
        {
            ISet<string> ansKeys = new HashSet<string>();
            ansKeys.Add("one");
            ansKeys.Add("two");
            ansKeys.Add("zero");
            ansKeys.Add("three");
            ISet<int> ansVals = new HashSet<int>();
            ansVals.Add(0);
            ansVals.Add(1);
            ansVals.Add(2);
            ansVals.Add(3);
            IDictionary<string, int> x = new Dictionary<string, int>();
            x["one"] = 1;
            x["zero"] = 0;
            x["three"] = 3;
            x["two"] = 2;

            foreach(var e in x)
            {
                Assert.True(ansKeys.Contains(e.Key));
                Assert.True(ansVals.Contains(e.Value));
            }
            foreach(string k in x.Keys)
                Assert.True(ansKeys.Contains(k));
            foreach(int v in x.Values)
                Assert.True(ansVals.Contains(v));
        }

        [Fact]
        public void TestTextMisc()
        {
            Assert.Equal("ABCD", "A"+'B'+'C'+"D");
            var ansChars = new char[]{'a', 'b', 'c', 'd'};
            string str = "abcd";
            var i = 0;
            foreach(var c in str)
            {
                Assert.Equal(c, ansChars[i++]);
            }
            Assert.Equal(4, "dogs".Length);
            Assert.Equal(4, ("d"+'o'+'c'+"g").Length);

            Assert.True("" == "emptiness".Substring(9));
            Assert.Throws<ArgumentOutOfRangeException>(
                () => "emptiness".Substring(10));
            Assert.Throws<ArgumentOutOfRangeException>(
                () => "emptiness".Substring(2, 8));
            Assert.True("" == "emptiness".Substring(0, 0));
        }

        [Fact]
        public void TestArrayConstruction()
        {
            int[] x = new int[4];
            var y = new int[4];
            Assert.True(true);
        }

        [Fact]
        public void TestStatementsMisc()
        {
            int[] data = null;
            var i = 1;
            if(data != null && i < data.Length && data[i] != -1)
            {
                Assert.True(false);
            }
        }
    }
}
