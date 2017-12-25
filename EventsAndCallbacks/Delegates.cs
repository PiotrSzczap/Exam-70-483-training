using System;

namespace EventsAndCallbacks
{
    public class Delegates
    {
        public delegate int Calculate(int x, int y);
        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }
        public void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); 
            calc = Multiply;
            Console.WriteLine(calc(3, 4));
            calc += Add;
        }


    }
}
