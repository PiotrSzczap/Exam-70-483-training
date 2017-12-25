using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Temp<Sample> t = new Temp<Sample>();
            var x = t.GetT();

        }
    }

    public class Sample
    {
        public Sample()
        {
            Console.WriteLine("Text");
        }
    }

    public class Temp<T> where T : class, new()
    {
        public T GetT()
        {
            return new T();
        }
    }
}
