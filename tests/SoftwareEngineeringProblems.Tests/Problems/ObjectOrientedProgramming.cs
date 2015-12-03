using Xunit;
using SoftwareEngineeringProblems.ObjectOrientedProgramming;

namespace SoftwareEngineeringProblems.Tests.ObjectOrientedProgramming
{
    public class ObjectsFixture
    {
        // C is-a B is-a A
        public A a = new A();
        public B b = new B();
        public C c = new C();
        public D d = new D();
    }

    public class ObjectOrientedProgrammingTests : IClassFixture<ObjectsFixture>
    {
        ObjectsFixture fixture;
        private A a;
        private B b;
        private C c;
        private D d;

        public ObjectOrientedProgrammingTests(ObjectsFixture fixture)
        {
            this.fixture = fixture;
            a = fixture.a;
            b = fixture.b;
            c = fixture.c;
            d = fixture.d;
        }

        [Fact]
        public void VirtualMethods()
        {
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

        [Fact]
        public void InheritedMethodAccesibility()
        {
            Assert.True(b.APublicMethod() == 'A');
        }

        [Fact]
        public void AbstractMethods()
        {
            Assert.True(a.AnAbstractProperty == "AAbs");
            Assert.True(b.AnAbstractProperty == "BAbs");
            Assert.True(c.AnAbstractProperty == "CAbs");
            Assert.True(d.AnAbstractProperty == "DAbs");

            // Redundant casts
            Assert.True(((AAbs)a).AnAbstractProperty == "AAbs");
            Assert.True(((AAbs)b).AnAbstractProperty == "BAbs");

            // Calls overrider method nearest to the type of the object
            // instance.
            Assert.True(((AAbs)c).AnAbstractProperty == "BAbs");
            Assert.True(((A)c).AnAbstractProperty == "BAbs");
            Assert.True(((B)c).AnAbstractProperty == "BAbs");
            // Redundant cast
            Assert.True(((C)c).AnAbstractProperty == "CAbs");
        }
    }
}