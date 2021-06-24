using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exarcise1 {
    class Program {
        static void Main(string[] args) {
            //5.1
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            Exarcise1_1(s1, s2);
        }
        private static void Exarcise1_1(string s1, string s2) {
            if(String.Compare(s1,s2,ignoreCase:true) == 0) {
                Console.WriteLine("２つの文字列は等しいです。");
            }else {
                Console.WriteLine("２つの文字列は等しくないです。");
            }
        }
    }
}