using System;
using System.Threading;

namespace ImplementMultithreading
{
    public static class ThreadStaticAttributeSample
    {
        [ThreadStatic]
        public static int _field;

        public static void Execute()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    _field++;
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    _field++;
                }
            }).Start();
        }
    }
}
