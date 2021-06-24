using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
        //フォームロードタイニングに１回だけ実行される　※コンストラクタの次に実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
        }
        //問１
        private void ButtonQ1_Click(object sender, EventArgs e) {
            AnsText.ResetText();
            var ans =  inputStrText.Text.Count(n => n == ' ');
            AnsText.Text = ans.ToString();
        }
        //問２
        private void ButtonQ2_Click(object sender, EventArgs e) {
            AnsText.ResetText();
            var target = inputStrText.Text;
            var ans = target.Replace("big", "small");
            AnsText.Text = ans;
        }
        //問３
        private void ButtonQ3_Click(object sender, EventArgs e) {
            AnsText.ResetText();
            AnsText.Text = inputStrText.Text.Split(' ').Count().ToString();
        }
        //問４
        private void ButtonQ4_Click(object sender, EventArgs e) {
            AnsText.ResetText();
            var words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach(var n in words) {
                AnsText.Text += n + ",";
            }
        }
        //問５
        private void ButtonQ5_Click(object sender, EventArgs e) {
            AnsText.ResetText();
            var words = inputStrText.Text.Split(' ');
            var sb = new StringBuilder();
            foreach(var n in words) {
                sb.Append(n);
            }
            var text = sb.ToString();
            AnsText.Text = text;

        }
        //問２改
        private void button1_Click(object sender, EventArgs e) {
            var target = inputStrText.Text;
            var ans = target.Replace(BeforeText.Text,AfterText.Text);
            AnsText.Text = ans;
        }
    }
}
