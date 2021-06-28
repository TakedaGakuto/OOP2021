using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            /*Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本のページ数の合計は" + books.Sum(x => x.Pages)+ "ページ");
            Console.WriteLine("最も高価な本は、" + books.Max(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("最も安価な本は、" + books.Min(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("500円以上の本は、" + books.Count(x => x.Price >= 500) +"冊");
            Console.WriteLine("「物語」が含まれている本は、" + books.Count(x => x.Title.Contains("物語")) +"冊");

            var titles = books.Where(x => x.Title.Contains("物語"));
            foreach(var book in titles) {
                Console.WriteLine(book.Title);
            }
            int i = 1;
            Console.WriteLine("高額な本ベスト３は、");
            var best = books.OrderByDescending(x => x.Price).Take(3);
            foreach(var best3 in best) {
                Console.WriteLine("{0}位　{1} {2}円",i++,best3.Title,best3.Price);
            }*/
            //P178
            var titles = books.Select(x => x.Title);
            foreach(var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
