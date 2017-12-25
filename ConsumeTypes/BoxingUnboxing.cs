using System;

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
