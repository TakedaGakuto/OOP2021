using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var str = "Cozy lummox gives smart squid who asks for job pen";
            
            Exercise1_1(str);
            Console.WriteLine("-----");

            Exercise1_2(str);
        }

        private static void Exercise1_1(string str) {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var c in str.ToUpper().Replace(" ","").OrderBy(x=>x)) {
                if (dict.ContainsKey(c)) {
                    dict[c] += 1;
                }
                else {
                    dict[c] = 1;
                }
            }
            foreach(var d in dict) {
                Console.WriteLine("'{0}':{1}",d.Key,d.Value);
            }
        }

        private static void Exercise1_2(string str) {
            SortedDictionary<char, int> sdict = new SortedDictionary<char, int>();
            foreach (var c in str.ToUpper().Replace(" ", "")) {
                if (sdict.ContainsKey(c)) {
                    sdict[c] += 1;
                }
                else {
                    sdict[c] = 1;
                }
            }
            foreach (var d in sdict) {
                Console.WriteLine("'{0}':{1}", d.Key, d.Value);
            }
        }
    }
}
