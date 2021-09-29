using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class Form1 : Form
    {
        Settings Set = new Settings();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信インスタンス作成
                MailMessage mailMessage = new MailMessage();
                //差出
                mailMessage.From = new MailAddress(Set.MailAddress);
                //To
                mailMessage.To.Add(tbTo.Text);
                //Cc
                mailMessage.CC.Add(tbCc.Text);
                //Bcc
                mailMessage.Bcc.Add(tbBcc.Text);
                //タイトル
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;
                //SMTPを使用してメール送信
                SmtpClient smtpClient = new SmtpClient();
                //認証情報設定(ユーザー名、パスワード)
                smtpClient.Credentials 
                    = new NetworkCredential(Set.MailAddress,Set.PassWord);
                smtpClient.Host = Set.Host;
                smtpClient.Port = Set.Port;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
