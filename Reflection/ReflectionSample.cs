using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(object application);
    }

    public class MyPlugin : IPlugin
    {
        public string Name
        {
            get { return nameof(Name); }
        }
        public string Description
        {
            get { return nameof(Description); }
        }
        public bool Load(object application)
        {
            return true;
        }
    }
    public class ReflectionSample
    {
        public static void Test()
        {
            Assembly pluginAssembly = typeof(IPlugin).Assembly;
            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;
            foreach (Type pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
            }
        }

        public static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }

        static ReflectionSample() { }

        public static void MethodInvoke()
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo",
            new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
        }
    }
}
