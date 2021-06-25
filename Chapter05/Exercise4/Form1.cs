using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void RunButton_Click(object sender, EventArgs e) {
            foreach(var pair in inputStrText.Text.Split(';')) {
                var array = pair.Split('=').ToArray();
                AnsText.Text += ToJapanese(array[0]) + ":" + array[1]+"\r\n";
            }
        }

        private string ToJapanese(string Key) {
            switch (Key) {
                case "Novelist":
                    return "作者　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            
            throw new ArgumentException("引数が正しくありません。");
        }
    }
}
