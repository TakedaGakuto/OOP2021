using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class SettingForm : Form
    {
        Settings Set = new Settings();
        public SettingForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = Set.sHost();
            tbPort.Text = Set.sPort();
            tbUserName.Text = Set.sMailAddress();
            tbPassWord.Text = Set.sPassWord();
            tbSender.Text = Set.sMailAddress();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbHost.Clear();
            tbPort.Clear();
            tbUserName.Clear();
            tbPassWord.Clear();
            tbSender.Clear();
        }
        //反映&ウィンド閉
        private void btOK_Click(object sender, EventArgs e)
        {
            Set.Host = tbHost.Text;
            Set.Port = int.Parse(tbPort.Text);
            Set.PassWord = tbPassWord.Text;
            Set.MailAddress = tbUserName.Text;
            Set.SSL = cbSSL.Checked;
            this.Close();
        }
        //反映
        private void btAdaption_Click(object sender, EventArgs e)
        {
            Set.Host = tbHost.Text;
            Set.Port = int.Parse(tbPort.Text);
            Set.PassWord = tbPassWord.Text;
            Set.MailAddress = tbUserName.Text;
            Set.SSL = cbSSL.Checked;
        }
    }
}
