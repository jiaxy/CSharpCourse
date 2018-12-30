using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XPathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(@".\..\..\BookList.xml");
                XmlNode root = xd.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/dotnet_books/book/title");
                foreach(XmlNode node in nodes)
                {
                    Console.WriteLine(node.InnerText);
                }

                XmlNode book1 = root.SelectSingleNode("/dotnet_books/book[1]/@isbn");
                Console.WriteLine(book1.Value);

                XmlNode book2 = root.SelectSingleNode("//book[@isbn='1861004915']/title");
                Console.WriteLine(book2.InnerText);


            }
            catch (XmlException e)
            {
                Console.WriteLine("Exception caught:  " + e.ToString());
            }
        }
    }
}
