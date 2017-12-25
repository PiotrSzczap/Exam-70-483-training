namespace EnforceEncapsulation
{
    interface InterfaceA
    {
        void Method();
    }
    interface InterfaceB
    {
        void Method();
    }
    class InterfaceImplementations : InterfaceA, InterfaceB
    {
        public void Method() { }
        void InterfaceB.Method() { }
    }
}
