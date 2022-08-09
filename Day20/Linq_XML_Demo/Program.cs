using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_XML_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"<?xml version=""1.0""?>
                        <Country name=""India"">
                            <Capital>NewDelhi</Capital>
                                </Country>";
            //preservtative whitespaces
            XDocument xDoc = XDocument.Parse(str, LoadOptions.PreserveWhitespace);
            Console.WriteLine(xDoc);
            Console.ReadLine();


        }
    }
}
