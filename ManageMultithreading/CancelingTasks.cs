using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
