using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_XML_Sort_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"C:\Users\vishal.rathore\source\repos\Day20\ELibrary.xml");
            var dict = (from element in xelement.Descendants("book")
                        let name = (string)element.Attribute("author")
                        orderby name
                        select new
                        {

                            Title = element.Attribute("title").Value,
                            AuthorName = name
                        }).ToDictionary(c => c.Title, c => c.AuthorName);

            foreach(var item in dict)
            {
                Console.WriteLine("Book's Title : {0}  ||  Author : {1}",item.Key,item.Value);
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();


            }
            Console.ReadLine();
        }
    }
}
