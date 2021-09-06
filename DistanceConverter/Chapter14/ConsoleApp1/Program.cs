using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        //コンストラクタ
        public Program()
        {
            //DownloadString();
            //DownloadFileAsync();
            //OpenReadSample();
            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine("1:前橋");
            Console.WriteLine("2:みなかみ");
            Console.WriteLine("3:宇都宮");
            Console.WriteLine("4:水戸");
            Console.WriteLine("5:その他");
            Console.Write("上記のコードから選択:");
            int num = int.Parse(Console.ReadLine());
            int code = 0;
            Dictionary<String, int> PrefDic = new Dictionary<string, int>()
            {
                { "前橋",4210 },
                { "みなかみ",4220 },
                { "宇都宮",4110 },
                { "水戸",4010 },
            };
            if (num <= 4)
            {
                foreach (var n in PrefDic)
                {
                    code = n.Value;
                }
            }
            else if(num == 5)
            {
                Console.Write("地域コード:");
                code = int.Parse(Console.ReadLine());
            }
            var result = GetWeatherReportFromYahoo(code);
            foreach(var s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
        //Webページ取得
        public void DownloadString()
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }
        //リスト14.17(非同期)
        private void DownloadFileAsync()
        {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\gt32042\Desktop\Sample.txt");
            var filename = @"C:\temp\example.txt";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//APが終了しないように
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("ダウンロード完了");
        }

        //リスト14.18(ストリーム)
        public void OpenReadSample()
        {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"https://yahoo.co.jp/"))
            using (var sr = new StreamReader(stream, Encoding.UTF8))
            {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
        }

        //14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
