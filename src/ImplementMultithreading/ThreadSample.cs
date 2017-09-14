using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementMultithreading
{
    public static class ThreadSample
    {
        public static void ThreadSampleMethod()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethod));
            thread.Start(5);
            thread.IsBackground = true;
            thread.Join();
        }

        public static void ThreadMethod(object parameter)
        {
            // Do something
        }
    }
}
