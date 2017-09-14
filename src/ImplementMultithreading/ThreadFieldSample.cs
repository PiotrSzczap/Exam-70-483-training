using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementMultithreading
{
    public static class ThreadFieldSample
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);

        public static void Execute()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    _field.Value++;
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    _field.Value++;
                }
            }).Start();
        }
    }
}
