using System.Threading;

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
