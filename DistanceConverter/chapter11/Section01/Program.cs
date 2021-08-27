﻿using System;
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

            /*var xelements = xdoc.Root.Elements()
                .Where(x=>((DateTime)x.Element("birth")).Year >= 1900);
            var xelements = xdoc.Root.Elements()
                .OrderBy(x => (string)(x.Element("birth")));*/
            
            foreach (var novelist in novelists)
            {
                Console.WriteLine("{0} ({1}-{2})",novelist.Name,novelist.Birth.Year,novelist.Death.Year);
            }
        }

        public IEnumerable<Novelist> ReadNovelists()
        {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                                .Select(x => new Novelist
                                {
                                    Name = (string)x.Element("name"),
                                    KanaName = (string)(x.Element("name").Attribute("kane")),
                                    Birth = (DateTime)x.Element("birth"),
                                    Death = (DateTime)x.Element("death"),
                                    Masterpieces = x.Element("masterpieces")
                                                    .Elements("title")
                                                    .Select(title => title.Value)
                                                    .ToArray()
                                });
            return novelists.ToArray();
        }


    }
}