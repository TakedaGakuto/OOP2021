using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            OpenReadSample();
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
    }
}
