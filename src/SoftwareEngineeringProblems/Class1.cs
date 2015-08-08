using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList;

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
}
