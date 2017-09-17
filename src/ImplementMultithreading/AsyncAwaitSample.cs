using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementMultithreading
{
    public static class AsyncAwaitSample
    {
        public static async Task MethodAsync()
        {
            int i = await MethodWithResultAsync();
            Console.WriteLine(i);
        }

        public static async Task<int> MethodWithResultAsync()
        {
            return await Task.FromResult(5);
        }
    }
}
