using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Execise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("11_2.xml");
            var xelements = xdoc.Root.Elements();
            var newfile = "ReExecise2.xml";
            foreach(var xlists in xelements)
            {
                XElement xkanji = xlists.Element("kanji");
                XElement xyomi = xlists.Element("yomi");

                var element = new XElement("difficultkanji",
                              new XElement("word",
                              new XElement("kanji", xkanji.Value),
                              new XElement("yomi", xyomi.Value)));
                xdoc.Root.Add(element);
            }
            xdoc.Save(newfile);
        }
    }
}
