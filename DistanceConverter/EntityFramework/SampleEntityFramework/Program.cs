using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //データの追加
            //InsertBooks();
            //GetBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();
            //Query1();
            //Console.WriteLine("-----");
            //Query2();
            //Console.WriteLine("-----");
            //Query3();
            //Console.WriteLine("-----");
            //Query4();

            Console.WriteLine("1----");
            Execise1();
            Console.WriteLine("2----");
            Execise2();
            Console.WriteLine("3----");
            Execise3();
            Console.WriteLine("4----");
            Execise4();
            Console.WriteLine("5----");
            Execise5();
            Console.ReadLine();

            /*using (var db = new BooksDbContext())
            {
                db.Database.Log = sql => { Debug.Write(sql); };
                var count = db.Books.Count();
                Console.WriteLine(count);
            }
            Console.ReadLine();*/

        }

        private static void Execise1()
        {
            Console.WriteLine("著者を追加しますか?(No:0 Yes:1)");
            var ans1 = Console.ReadLine();
            if(int.Parse(ans1) == 1)
            {
                AuthorAdd();
            }
            Console.WriteLine("本を追加しますか?(No:0 Yes:1)");
            var ans2 = Console.ReadLine();
            if(int.Parse(ans2) == 1)
            {
                BookAdd();
            }
                #region ソース入力
                /*using (var db = new BooksDbContext())
                {
                    var author1 = new Author
                    {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛"
                    };
                    db.Authors.Add(author1);

                    var author2 = new Author
                    {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成"
                    };
                    db.Authors.Add(author2);
                    db.SaveChanges();
                }
                using (var db = new BooksDbContext())
                {
                    var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                    var book1 = new Book
                    {
                        Title = "こころ",
                        PublishedYear = 1991,
                        Author = author1,
                    };
                    db.Books.Add(book1);

                    var author2 = db.Authors.Single(a => a.Name == "川端康成");
                    var book2 = new Book
                    {
                        Title = "伊豆の踊子",
                        PublishedYear = 2003,
                        Author = author2,
                    };
                    db.Books.Add(book2);

                    var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                    var book3 = new Book
                    {
                        Title = "真珠夫人",
                        PublishedYear = 2002,
                        Author = author3,
                    };
                    db.Books.Add(book3);

                    var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                    var book4 = new Book
                    {
                        Title = "注文の多い料理店",
                        PublishedYear = 2000,
                        Author = author4,
                    };
                    db.Books.Add(book4);
                    db.SaveChanges();*/
                #endregion
            }

        private static void AuthorAdd()
        {
            Console.Write("誕生日:");
            var birthday = Console.ReadLine();
            Console.Write("性別(M・F):");
            var gender = Console.ReadLine();
            Console.Write("名前:");
            var name = Console.ReadLine();
            using (var db = new BooksDbContext())
            {
                var author = new Author
                {
                    Birthday = DateTime.Parse(birthday),
                    Gender = gender,
                    Name = name
                };
                db.Authors.Add(author);
                db.SaveChanges();
                Console.WriteLine("著者を追加しますか?(No:0 Yes:1)");
                var ans1 = Console.ReadLine();
                if (int.Parse(ans1) == 1)
                {
                    AuthorAdd();
                }
            }
        }
        private static void BookAdd()
        {
            Console.Write("著者名:");
            var name = Console.ReadLine();
            Console.Write("タイトル:");
            var title = Console.ReadLine();
            Console.Write("公開年:");
            var publishedyear = Console.ReadLine();
            using (var db = new BooksDbContext())
            {
                var author = db.Authors.Single(a => a.Name == name);
                var book = new Book
                {
                    Title = title,
                    PublishedYear = int.Parse(publishedyear),
                    Author = author,
                };
                db.Books.Add(book);
                Console.WriteLine("本を追加しますか?(No:0 Yes:1)");
                var ans2 = Console.ReadLine();
                db.SaveChanges();
                if (int.Parse(ans2) == 1)
                {
                    BookAdd();
                }
            }
        }

        private static void Execise2()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books;
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title}:{book.PublishedYear}:{book.Author.Name}");
                }
            }
        }

        private static void Execise3()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books.Where(x => x.Title.Length == db.Books.Max(a => a.Title.Length));
                foreach(var book in books)
                {
                    Console.WriteLine($"{book.Title}");
                }
            }
        }

        private static void Execise4()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books.OrderBy(x => x.PublishedYear).Take(3);
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title}:{book.Author.Name}");
                }
            }
        }

        private static void Execise5()
        {
            using (var db = new BooksDbContext())
            {
                var authors = db.Authors.OrderByDescending(x => x.Birthday);
                var books = db.Books.OrderBy(x => x.Author.Id);
                foreach (var author in authors)
                {
                    Console.WriteLine(author.Name);
                    foreach(var book in books)
                    {
                        if(author.Id == book.Author.Id)
                        {
                            Console.WriteLine($"・{book.Title}:{book.PublishedYear}");
                        }
                    }
                    Console.WriteLine("");
                }
            }
        }

        //書籍が２冊以上の著者
        private static void Query1()
        {
            using (var db = new BooksDbContext())
            {
                var authors = db.Authors.Where(a => a.Books.Count() >= 2);
                foreach (var author in authors)
                {
                    Console.WriteLine($"{author.Name}{author.Gender}{author.Birthday}");
                }
            }
        }

        //出版年、著者名の昇順
        private static void Query2()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books.OrderBy(b => b.PublishedYear).ThenBy(b => b.Author.Name);
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title}:{book.PublishedYear}:{book.Author.Name}");
                }
            }
        }
        
        //発行年ごとの書籍数
        private static void Query3()
        {
            using (var db = new BooksDbContext())
            {
                var groups = db.Books.GroupBy(b => b.PublishedYear)
                                     .Select(g => new { Year = g.Key, Count = g.Count() });
                foreach (var g in groups)
                {
                    Console.WriteLine($"{g.Year}:{g.Count}");
                }
            }
        }
        
        //最も冊数の多い著者
        private static void Query4()
        {
            using (var db = new BooksDbContext())
            {
                var author = db.Authors.Where(a => a.Books.Count() ==
                                              db.Authors.Max(x => x.Books.Count())).First();
                Console.WriteLine($"{author.Name}:{author.Gender}:{author.Birthday.ToString("YYYY/MM/dd")}");
            }
            Console.ReadLine();
        }

        // List 13-5
        static void InsertBooks()
        {
            //DB接続はここだけ
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges();
            }
        }

        //List 13-7
        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                //.ToList()がないと遅延実行になるからエラーになる
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        //List 13-8
        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            //一時停止
            Console.ReadLine();
        }

        // List 13-9
        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }

        }
        
        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
        
        //List 13-11
        private static void UpdateBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }
        
        //List 13-12
        private static void DeleteBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if(book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }
}
