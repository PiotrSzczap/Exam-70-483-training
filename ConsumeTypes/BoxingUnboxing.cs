using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes
{
    class BoxingUnboxing
    {
        public void Boxing()
        {
            int i = 42;
            object o = i;
        }

        public void UnBoxing()
        {
            Object i = 42;
            int o = (int)i;
        }
    }
}
