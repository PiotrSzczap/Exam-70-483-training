using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementMultithreading
{
    public static class ParallelSample
    {
        public static void Execute()
        {
            Parallel.For(0, 10, Console.WriteLine);

            var numbers = Enumerable.Range(0, 1000);
            numbers.AsParallel().Where(t=>t % 2 == 0).AsOrdered().ForAll(Console.WriteLine);
        }
    }
}
