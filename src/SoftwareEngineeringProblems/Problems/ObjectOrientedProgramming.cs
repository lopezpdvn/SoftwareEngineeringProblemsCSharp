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

        private char APrivateMethod()
        {
            return 'A';
        }

        protected char AAnInternalMethod()
        {
            return 'A';
        }
    }

    public class B : A
    {
        public new char SomeNonVirtualProperty => 'B';
        public override char SomeVirtualProperty => 'B';

        public char APublicMethod()
        {
            return AAnInternalMethod();
        }
    }

    public class C : B
    {
        public new char SomeNonVirtualProperty => 'C';
        public override char SomeVirtualProperty => 'C';
    }
}
