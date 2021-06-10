using Exarcise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exarcise2 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var yms = new YearMonth[] {
                new YearMonth(2001,1),
                new YearMonth(2001,12),
                new YearMonth(2002,2),
                new YearMonth(2002,11),
                new YearMonth(2003,12)
            };
            //4.2.2
            Exarcise2_2(yms);
            //4.2.4
            Exarcise2_4(yms);
            //4.2.5
            Exarcise2_5(yms);
        }

        private static void Exarcise2_2(YearMonth[] yms) {
            foreach(var n in yms) {
                Console.WriteLine(n);
            }
        }
        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach(var n in yms) {

            }
        }

        private static void Exarcise2_4(YearMonth[] yms) {
            throw new NotImplementedException();
        }

        private static void Exarcise2_5(YearMonth[] yms) {
            throw new NotImplementedException();
        }
    }
}