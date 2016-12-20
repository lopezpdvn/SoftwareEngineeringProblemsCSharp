using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using DataStructuresAlgorithms.DataStructures.LinkedList;
using DataStructuresAlgorithms.DataStructures.LinkedList.SinglyLinkedList;

namespace SoftwareEngineeringProblems
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {
        public Class1()
        {

        }

        static public int Add(int x, int y)
        {
            return x + y;
        }

        static public bool returnTrue()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            Console.WriteLine(list);
            return false;
        }

    }

    public class AnIntGenericCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
                yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator()     // Explicit implementation
        {                                           // keeps it hidden.
            return GetEnumerator();
        }
    }

    public class AnIntCollection : IEnumerable
    {
        int[] data = { 1, 2, 3 };

        public IEnumerator GetEnumerator()
        {
            foreach (var i in data)
                yield return i;
        }
    }
}
