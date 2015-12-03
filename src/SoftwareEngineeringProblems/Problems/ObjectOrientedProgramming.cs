namespace SoftwareEngineeringProblems.ObjectOrientedProgramming
{
    public abstract class AAbs {
        public abstract string AnAbstractProperty { get; }
    }

    public class A : AAbs
    {
        public char SomeNonVirtualProperty => 'A';
        public virtual char SomeVirtualProperty => 'A';

        /* Implementation must use override modifier. new modifier can
        be used, but doesn't count as implementing the abstract parent
        class method because it would be hiding it instead of
        overriding it. */
        public override string AnAbstractProperty => "AAbs";

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

        public override string AnAbstractProperty => "BAbs";
    }

    public class C : B
    {
        public new char SomeNonVirtualProperty => 'C';
        public override char SomeVirtualProperty => 'C';
        public new string AnAbstractProperty => "CAbs";
    }

    public class D : C
    {
        // Compile errors.
        //public override string AnAbstractProperty => "DAbs";
        //public string AnAbstractProperty => "DAbs";
        public new string AnAbstractProperty => "DAbs";
    }
}
