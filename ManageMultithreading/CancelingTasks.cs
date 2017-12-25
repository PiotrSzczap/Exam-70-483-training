using System;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMultithreading
{
    public static class CancelingTasks
    {
        public static void CancelationTokenSample()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    // do something
                }
            });

            cancellationTokenSource.Cancel();
        }

        public static void CanceledException()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    // do something
                }

                cancellationToken.ThrowIfCancellationRequested();
            });

            try
            {
                cancellationTokenSource.Cancel();
            }
            catch (AggregateException exception)
            {
                
            }
            Console.ReadLine();
        }
    }
}
