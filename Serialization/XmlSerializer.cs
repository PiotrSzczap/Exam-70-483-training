using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class XmlSerializator
    {
        public class Data { }
        public void Execute()
        {
            string s = "";
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
                xmlSerializer.Serialize(sw, new Data());
                s = sw.ToString();
            }
        }
    }
}
