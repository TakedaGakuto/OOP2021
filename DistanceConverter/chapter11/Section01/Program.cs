using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("novelists.xml");
            /*var xelements = xdoc.Root.Elements()
                .Where(x=>((DateTime)x.Element("birth")).Year >= 1900);
            var xelements = xdoc.Root.Elements()
                .OrderBy(x => (string)(x.Element("birth")));*/
            var xtitles = xdoc.Root.Descendants("title");
            foreach (var xtitle in xtitles)
            {
                Console.WriteLine(xtitle.Value);
            }
        }
    }
}
