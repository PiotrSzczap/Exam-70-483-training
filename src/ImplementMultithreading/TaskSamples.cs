using System;
using System.Threading.Tasks;

namespace ImplementMultithreading
{
    public static class TaskSamples
    {
        public static void TaskWithContinueExecute()
        {
            Task<int> task = Task.Run(() => Int32.MaxValue);

            task.ContinueWith((i) =>
            {
                //Do something
            }, TaskContinuationOptions.OnlyOnFaulted);

            task.Wait();
        }
    }
}
