using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ValidateInput
{
    class JsonAndXml
    {
        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
|| input.StartsWith("[") && input.EndsWith("]");
        }

        public void ValidateXML()
        {
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";
            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);
            ValidationEventHandler eventHandler =
            new ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
        }
        static void ValidationEventHandler(object sender,
        ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: { 0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning { 0}", e.Message);
                    break;
            }
        }

    }
}
