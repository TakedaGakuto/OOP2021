using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRun_Click(object sender, EventArgs e) {
            Q1();
            
        }

        private void Q1() {
            var today = DateTime.Now;
            tbQ1.Text = string.Format("{0:yyyy/M/d HH:mm}\r\n", today);
            tbQ1.Text += string.Format("{0:yyyy年M月d日 HH時mm分ss秒}\r\n", today);
            //和暦
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = today.ToString("ggyy年M月d日", culture);
            tbQ1.Text += string.Format("{0}({1})", str, culture.DateTimeFormat.GetDayName(today.DayOfWeek));

        }

        private void Form1_Load(object sender, EventArgs e) {
            var tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 500;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}
