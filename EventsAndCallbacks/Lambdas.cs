using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndCallbacks
{
    public class Lambdas
    {
        public delegate int Calculate(int x, int y);
        public void Test()
        {

            Calculate meth = (x, y) =>
            {
                return x + y;
            };
            meth.Invoke(2,2);

            Action action = () => { Console.WriteLine("Action"); };
            Func<bool> func = () => { return true; };
            Predicate<int> predicate = (i) => { return true; };
        }
    }
}
