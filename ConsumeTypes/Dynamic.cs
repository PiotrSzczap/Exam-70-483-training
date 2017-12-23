using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes
{
    public class SampleObject : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = binder.Name;
            return true;
        }

        public override bool TryCreateInstance(CreateInstanceBinder binder, object[] args, out object result)
        {
            result = binder;
            return true;
        }
    }
    class Dynamic
    {
        public static void Something()
        {
            var entities = new List<dynamic> {
                new ExpandoObject(),                
                new ExpandoObject(),
            };

            foreach(dynamic d in entities)
            {
                d.ColumnC = "C";
            }

            entities.Add(new SampleObject());
            foreach (dynamic d in entities)
            {
                d.ColumnD = "D";
            }
        }
    }
}
