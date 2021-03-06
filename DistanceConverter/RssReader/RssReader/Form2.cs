using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form2 : Form
    {
        public static XElement Item { get; set; }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            wbBrowser.Navigate(Item.Element("link").Value);
             btReturn.Enabled = false;
             btGo.Enabled = false;
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            wbBrowser.GoBack();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            wbBrowser.GoForward();
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btReturn.Enabled = wbBrowser.CanGoBack == true ? true : false;
            btGo.Enabled = wbBrowser.CanGoForward == true ? true : false;
        }
    }
}


