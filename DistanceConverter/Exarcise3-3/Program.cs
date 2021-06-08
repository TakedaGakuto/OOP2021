using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exarcise3_3 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",};
            var words = new List<string> { };
            // 3.3.1
            Exercise3_1(names);
            Console.WriteLine("-----");
            //3.3.2
            Exarcise3_2(words);
        }

       

        private static void Exercise3_1(List<string> names) {
            int count1 = 0;
            int count2 = 0;
            foreach(var name in names) {
                count1 += name.Count(c => char.IsLower(c));
                count2 += name.Count(c => char.IsUpper(c));
            }
            Console.WriteLine(count1);
            Console.WriteLine(count2);
        }

        private static void Exarcise3_2(List<string> words) {

        }
    }
}
