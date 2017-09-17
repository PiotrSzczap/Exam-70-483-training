using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMultithreading
{
    static class SynchronizingResources
    {
        public static object _locker = new object();

        public static void LockSample()
        {
            Task.Factory.StartNew(() =>
            {
                lock (_locker)
                {
                    Thread.Sleep(1000);
                    //Do something
                }
            });
            Thread.Sleep(100);
            Task.Factory.StartNew(() =>
            {
                lock (_locker)
                {
                    //Do something
                }
            });
        }

        public static void MonitorSample()
        {
            object _gate = new object();
            bool _lockToken = false;
            Monitor.Enter(_lockToken, ref _lockToken);
            Monitor.Exit(_gate);

        }

        public static void InterlockedSample()
        {
            int i = 0;
            Interlocked.Add(ref i, 5);
            int y = Interlocked.Exchange(ref i, 5);
            int k=0;
            Interlocked.CompareExchange(ref y, i, k);
        }

    }
}
