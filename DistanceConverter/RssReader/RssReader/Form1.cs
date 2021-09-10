using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        //リンク用リスト
        List<XElement> Items = new List<XElement>();
        public Form1()
        {
            InitializeComponent();
     
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            GetWebsite(tbUrl.Text);
        }

        private void GetWebsite(string text)
        {
            
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                
                var stream = wc.OpenRead(tbUrl.Text);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");
                foreach(var node in nodes)
                {
                    Items.Add(node);
                    lbTitles.Items.Add(node.Element("title").Value);
                }
            }
            
        }

        public void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Item = Items[lbTitles.SelectedIndex];
            //②ブラウザ表示
            //webBrowser1.Navigate(Item.Element("link").Value);
            //③
            lbDescription.Text = Item.Element("description").Value.ToString();
            //④-2
            lbDescription.Text += DateTime.Parse(Item.Element("pubDate").Value.ToString());

            Form2.Item = Item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //④-3
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
