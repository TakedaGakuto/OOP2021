using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail
{
    public partial class Form1 : Form
    {
        SettingForm settingform = new SettingForm();
        private Settings Set = Settings.getInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            settingform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ans = Set.FileCheck();
            if (ans != true)
            {
                settingform.ShowDialog();
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                btSend.Enabled = false;
                //メール送信インスタンス作成
                MailMessage mailMessage = new MailMessage();
                //差出
                mailMessage.From = new MailAddress(Set.MailAddress);
                if (tbTo.Text != "" && tbMessage.Text != "")
                {
                //To
                mailMessage.To.Add(tbTo.Text);
                //Cc
                if (tbCc.Text != "")
                {
                    mailMessage.CC.Add(tbCc.Text);
                }
                //Bcc
                if (tbBcc.Text != "")
                {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                //タイトル
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;
                //SMTPを使用してメール送信
                SmtpClient smtpClient = new SmtpClient();
                //認証情報設定(ユーザー名、パスワード)
                smtpClient.Credentials
                    = new NetworkCredential(Set.MailAddress, Set.PassWord);
                smtpClient.Host = Set.Host;
                smtpClient.Port = Set.Port;
                smtpClient.EnableSsl = Set.SSL;
                //smtpClient.Send(mailMessage);
                string token = "SendMail";
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                smtpClient.SendAsync(mailMessage, token);
                }
                else
                MessageBox.Show("メールの内容に不備があります");
                btSend.Enabled = true;
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
                btSend.Enabled = true;
                TextReset();
            }
        }

        private void TextReset()
        {
            tbTo.Clear();
            tbCc.Clear();
            tbBcc.Clear();
            tbTitle.Clear();
            tbMessage.Clear();
            btSend.Enabled = true;
        }
        private void 終了FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextReset();
        }
    }
}
