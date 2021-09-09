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
            //リンク用リスト
            List<string> links = new List<String>();
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                
                var stream = wc.OpenRead(tbUrl.Text);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach(var node in nodes)
                {
                    links.Add(node.NextNode.ToString());
                    lbTitles.Items.Add(node.Value);
                }
            }
            
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbDiscription.Text = (Regex.Replace(Item.NextNode.NextNode.ToString(), "<pubDate>|</pubDate>", ""));
            //lbDiscription.Text += Regex.Replace(Item.NextNode.NextNode.NextNode.ToString(),"<description>|</description>","");
        }
    }
}
