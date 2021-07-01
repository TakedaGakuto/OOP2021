﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {

    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);
            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var book = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            if (book != null) {
                Console.WriteLine("価格:{0}", book.Price);
                Console.WriteLine("ページ数:{0}", book.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")));
        }

        private static void Exercise2_3(List<Book> books) {
            Console.WriteLine(books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages));
        }

        private static void Exercise2_4(List<Book> books) {
            var book = books.FirstOrDefault(x => x.Price >= 4000).Title;
            if(book != null) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            Console.WriteLine(books.Where(x => x.Price < 4000).Max(x => x.Pages));
        }

        private static void Exercise2_6(List<Book> books) {
            var book = books.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
            foreach (var x in book) {
                Console.WriteLine("タイトル:{0}　価格:{1}", x.Title, x.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var book = books.Where(x => x.Pages >= 500 && x.Title.Contains("C#"));
            foreach(var x in book) {
                Console.WriteLine(x.Title);
            }
        }
    }
}
