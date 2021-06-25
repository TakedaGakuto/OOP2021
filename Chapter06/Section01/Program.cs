using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本のページ数の合計は" + books.Sum(x => x.Pages)+ "ページ");
            Console.WriteLine("最も高価な本は、" + books.Max(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("最も安価な本は、" + books.Min(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("500円以上の本は、" + books.Where(x => x.Price >= 500).Count()+"冊");
        }
    }
}
