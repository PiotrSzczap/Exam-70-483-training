using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManipulateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void StringBuilderTest()
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }
        }

        static void StringWriterTest()
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
        }
    }
}
