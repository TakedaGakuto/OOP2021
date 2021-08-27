using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Execise1
{
    class Program
    {
        static void Main(string[] args)
        {

            var file = "Sample.xml";
            Execise1_1(file);
            Console.WriteLine("----------");
            Execise1_2(file);
            Console.WriteLine("----------");
            Execise1_3(file);
            Console.WriteLine("----------");
        }

        private static void Execise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
            foreach(var xlist in xelements)
            {
                XElement xname = xlist.Element("name");
                XElement xmember = xlist.Element("teammembers");
                Console.WriteLine("競技名:{0}チームメンバー数:{1}",xname.Value,xmember.Value);
            }
        }
        private static void Execise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                     .OrderBy(x => (int)(x.Element("firstplayed")));
            foreach(var xlist in xelements)
            {
                var xname = xlist.Element("name");
                XAttribute xkanji = xname.Attribute("kanji");
                Console.WriteLine(xkanji?.Value);
            }
        }

        private static void Execise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                     .OrderByDescending(x => (int)(x.Element("teammembers")));
            foreach(var xlist in xelements)
            {
                var xname = xlist.Element("name");
                Console.WriteLine(xname.FirstNode);
            }
        }
    }
}
