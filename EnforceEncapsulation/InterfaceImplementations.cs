using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
