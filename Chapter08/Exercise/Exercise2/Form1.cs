using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2

    {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }
        //起動時
        private void Form1_Load(object sender, EventArgs e) {
            lbTimer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }
        //スタートボタンクリック時
        private void btStart_Click(object sender, EventArgs e) {
            tm.Tick += Tm_Tick;
            tm.Interval = 10;
            tm.Start();
        }
        private void Tm_Tick(object sender, EventArgs e) {
            sw.Start();
            lbTimer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }
        //ストップボタンクリック時
        private void btStop_Click(object sender, EventArgs e) {
            tm.Stop();
            sw.Stop();
        }
        //リセットボタンクリック時
        private void btReset_Click(object sender, EventArgs e) {
            lbTimer.Text = "00:00:00.00";
            sw.Restart();
        }
        //ラップボタンクリック時
        private void btlap_Click(object sender, EventArgs e) {
        
        }
    }
}
