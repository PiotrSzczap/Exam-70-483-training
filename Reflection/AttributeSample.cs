using System;
using System.Linq;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    class SampleAttribute : Attribute
    {
        private string _description;
        public SampleAttribute(string description)
        {
            _description = description;
        }
        public int Count { get; set; }
    }
    [Sample("aa", Count = 1)]
    public class Something
    {
        public static void Test()
        {
            var types = typeof(Something).Assembly.GetTypes().Where(t => t.CustomAttributes.Select(u => u.AttributeType).Contains(typeof(SampleAttribute)));
            foreach(var type in types)
            {
                Console.WriteLine(type);
            }
        }
    }
}
