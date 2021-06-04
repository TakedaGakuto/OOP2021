using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exarcise2 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };
            
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            var line = Console.ReadLine();
            int index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
            
        }

        private static void Exercise2_2(List<string> names) {
            var count =names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var array = names.Where(s => s.Contains("o")).ToArray();
            foreach(var s in array) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var count = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach(var s in count) {
                Console.WriteLine(s);
            }
        }
    }
}
