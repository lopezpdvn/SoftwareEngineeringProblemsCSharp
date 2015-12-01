using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SoftwareEngineeringProblems.ObjectOrientedProgramming;

namespace SoftwareEngineeringProblems.Tests.ObjectOrientedProgramming
{
    public class ObjectOrientedProgrammingTests
    {
        [Fact]
        public void VirtualMethods()
        {
            // C is-a B is-a A
            A a = new A();
            B b = new B();
            C c = new C();

            Assert.True(a.SomeNonVirtualProperty == 'A');
            Assert.True(b.SomeNonVirtualProperty == 'B');
            Assert.True(c.SomeNonVirtualProperty == 'C');
            Assert.True(((B)c).SomeNonVirtualProperty == 'B');
            Assert.True(((A)c).SomeNonVirtualProperty == 'A');
            Assert.True(((A)b).SomeNonVirtualProperty == 'A');

            Assert.True(a.SomeVirtualProperty == 'A');
            Assert.True(b.SomeVirtualProperty == 'B');
            Assert.True(c.SomeVirtualProperty == 'C');
            // Below 3 casts are redundant.
            Assert.True(((B)c).SomeVirtualProperty == 'C');
            Assert.True(((A)c).SomeVirtualProperty == 'C');
            Assert.True(((A)b).SomeVirtualProperty == 'B');
        }
    }
}