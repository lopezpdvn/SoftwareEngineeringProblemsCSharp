using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProblems.ObjectOrientedProgramming
{
    public class A
    {
        public char SomeNonVirtualProperty => 'A';
        public virtual char SomeVirtualProperty => 'A';
    }

    public class B : A
    {
        public new char SomeNonVirtualProperty => 'B';
        public override char SomeVirtualProperty => 'B';
    }

    public class C : B
    {
        public new char SomeNonVirtualProperty => 'C';
        public override char SomeVirtualProperty => 'C';
    }
}
