using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SoftwareEngineeringProblems;

namespace SoftwareEngineeringProblems.Tests
{
    public class ArrayAndStrings
    {
        [Fact]
        public static void TestAreCharacterSetsEqual()
        {
            Assert.False(
                ArraysAndStrings.AreCharacterSetsEqual("abcdef", "cabhsdfdhgf"));
            Assert.True(
                ArraysAndStrings.AreCharacterSetsEqual("abcffffffffffed", "fbcade"));
            Assert.True(
                ArraysAndStrings.AreCharacterSetsEqual("abbbcf     ed", "fbfffcade "));
            Assert.True(
                ArraysAndStrings.AreCharacterSetsEqual("abcf   ed", "fbcade "));
        }

        [Fact]
        public static void TestReplaceSpaces0()
        {
            var originalStr = "abc d e f";
            var strExpected = "abc%20d%20e%20f";

            var newStrArray = new char[strExpected.Length];
            originalStr.ToCharArray().CopyTo(newStrArray, 0);

            ArraysAndStrings.ReplaceSpaces0(newStrArray, originalStr.Length);
            Assert.Equal(strExpected, new string(newStrArray));


            originalStr = "abcdef";
            strExpected = "abcdef";

            newStrArray = new char[strExpected.Length];
            originalStr.ToCharArray().CopyTo(newStrArray, 0);

            ArraysAndStrings.ReplaceSpaces0(newStrArray, originalStr.Length);
            Assert.Equal(strExpected, new string(newStrArray));
        }
    }
}