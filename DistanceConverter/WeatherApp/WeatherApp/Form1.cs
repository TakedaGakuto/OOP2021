using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btWeather_Click(object sender, EventArgs e)
        {

            string selectedItem = cbPrifecture.SelectedItem.ToString();
            tbResult.Text += selectedItem;
            int code = 0;
            
            Dictionary<String, int> PrefDic = new Dictionary<string, int>()
            {
                { "栃木",4000 },
                { "茨城",4110 },
                { "群馬",4210 },
                { "埼玉",4310 },
                { "東京",4410 },
                { "千葉",4510 },
                { "神奈川",4610 },
            };
            foreach (var n in PrefDic)
            {
                if(n.Key == selectedItem)
                {
                    code = n.Value;
                }
            }
            int num = code;
            var result = GetWeatherReportFromYahoo(num);

            if(result.ToString().Contains("該当する地点はありません。"))
            {
                tbResult.Text = "地域はありません。";
            }
            else
            {
                foreach (var s in result)
                {
                    tbResult.Text += s;
                    tbResult.AppendText(Environment.NewLine);
                }
            } 
            
        }
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
