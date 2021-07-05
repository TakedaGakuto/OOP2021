using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var day = new DateTime((int)nudYear.Value ,(int)nudMonth.Value,(int)nudDay.Value);
            DayOfWeek dayofweek = day.DayOfWeek;
            
            /*switch (dayofweek) {
                case DayOfWeek.Sunday:
                    tbOutput.Text = ("日曜日です。");
                    break;
                case DayOfWeek.Monday:
                    tbOutput.Text = ("月曜日です。");
                    break;
                case DayOfWeek.Tuesday:
                    tbOutput.Text = ("火曜日です。");
                    break;
                case DayOfWeek.Wednesday:
                    tbOutput.Text = ("水曜日です。");
                    break;
                case DayOfWeek.Thursday:
                    tbOutput.Text = ("木曜日です。");
                    break;
                case DayOfWeek.Friday:
                    tbOutput.Text = ("金曜日です。");
                    break;
                case DayOfWeek.Saturday:
                    tbOutput.Text = ("土曜日です。");
                    break;
                default:
                    break;
            }*/
            //閏年
            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            }
            else {
                tbLeapYear.Text = "閏年ではありません。";
            }
            /*//経過日数
            var date1 = DateTime.Now;
            var date2 = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            TimeSpan ans = date1.Date - date2.Date;
            tbOutput.Text = "今日との差は" + Math.Abs(ans.Days) + "日です。";*/
            //年齢
            var birthday = GetAge(dtp1.Value, DateTime.Now);
            tbOutput.Text = birthday.ToString();
        }
        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
