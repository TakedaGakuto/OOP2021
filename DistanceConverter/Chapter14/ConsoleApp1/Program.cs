using System;
using System.Collections.Generic;
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
            DownloadString();
        }
        //Webページ取得
        public void DownloadString()
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }
    }
}
