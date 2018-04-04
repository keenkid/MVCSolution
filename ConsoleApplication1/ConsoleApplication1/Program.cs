using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            var declaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", string.Empty);
            xmlDoc.AppendChild(declaration);
                        
            var ndRoot = xmlDoc.CreateNode(XmlNodeType.Element, "root", string.Empty);
            var ndList = xmlDoc.CreateNode(XmlNodeType.Element, "list", string.Empty);
            ndRoot.AppendChild(ndList);

            var ndRefID = xmlDoc.CreateNode(XmlNodeType.Element, "refID", string.Empty);
            ndRefID.InnerText = "343434";
            ndList.AppendChild(ndRefID);

            xmlDoc.AppendChild(ndRoot);
            
            xmlDoc.Save(@"c:\users\keenkid.mao\desktop\test.xml");
            Console.WriteLine(xmlDoc.OuterXml);
        }
    }
}
