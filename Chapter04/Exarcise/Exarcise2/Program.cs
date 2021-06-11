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
                new YearMonth(1999,1),
                new YearMonth(2001,12),
                new YearMonth(2001,2),
                new YearMonth(2002,11),
                new YearMonth(2002,12)
            };
            //4.2.2
            Exarcise2_2(yms);
            //4.2.4
            Exarcise2_4(yms);
            //4.2.5
            Exarcise2_5(yms);
        }

        private static void Exarcise2_2(YearMonth[] yms) {
            foreach(var ym in yms) {
                Console.WriteLine(ym);
            }
            Console.WriteLine();
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach(var ym in yms) {
                if(ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }

        private static void Exarcise2_4(YearMonth[] yms) {
            /*var ans = FindFirst21C(yms);
            if(ans == null) {
                Console.WriteLine("21世紀のデータは、見つかりませんでした。");
            }else {
                Console.WriteLine(ans.Year);
            }*/
            var yearmonth = FindFirst21C(yms);
            var s = yearmonth != null ? yearmonth.Year.ToString() : "21世紀のデータは、見つかりませんでした。";
            Console.WriteLine(s);
            Console.WriteLine();
        }

        private static void Exarcise2_5(YearMonth[] yms) {
            var yearmonthes = yms.Select(n => n.AddOneMonth()).ToArray();
            foreach (var ym in yearmonthes) {
                Console.WriteLine(ym);
            }
        }
    }
}