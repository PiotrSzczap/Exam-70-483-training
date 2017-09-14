using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementMultithreading
{
    public static class ThreadPoolSample
    {
        public static void Execute()
        {
            ThreadPool.QueueUserWorkItem(state => 
            {
                //Do something
            });

        }
    }
}
