using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList;

namespace SoftwareEngineeringProblems
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class ArraysAndStrings
    {

        public static bool AreCharacterSetsEqual(string original, string val2Test)
        {
            var originalSet = new HashSet<char>(original);
            var val2TestSet = new HashSet<char>(val2Test);
            return originalSet.SetEquals(val2Test);
        }

        // Based on https://github.com/gaylemcd/ctci/blob/master/c-sharp/Chapter01/Q01_4.cs
        public static void ReplaceSpaces0(char[] str, int trueLength)
        {
            var nSpaces = 0;

            // count the number of spaces
            foreach (var c in str)
            {
                if (c == ' ')
                {
                    nSpaces++;
                }
            }

            // New string size. One can't assume it's str.Length,
            // we can only say that str.Length >= (new string size)
            var newStrSize = trueLength + (nSpaces * 2);

            // copying the characters backwards and inserting %20
            for (int i = trueLength - 1, j = newStrSize - 1; i >= 0; i--, j--)
            {
                if (str[i] == ' ')
                {
                    str[j] = '0';
                    str[--j] = '2';
                    str[--j] = '%';
                }
                else
                {
                    str[j] = str[i];
                }
            }
        }
    }
}
