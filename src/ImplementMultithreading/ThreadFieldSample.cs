using System.Threading;

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
