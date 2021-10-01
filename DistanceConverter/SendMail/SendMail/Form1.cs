﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            //XML確認処理
            var file = "mail.xml";
            Set.XMLFile = XDocument.Load(file).ToString();

            //var xdoc = XDocument.Load(file);
            //XML取得成功(Settingsへ登録)
            if (File.Exists(file))
            {

                //settingsへの登録
                //int
                //Set.Port = ;
                Set.Host = "";
                Set.PassWord = "";
                //true / false
                //Set.SSL = ;
                Set.MailAddress = "";
                Set.UserName = " ";
            }
            //XML取得失敗(SettingForm起動)
            else
            {
                settingform.ShowDialog();
            }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            settingform.ShowDialog();
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
                if(tbCc.Text != "")
                {
                    mailMessage.CC.Add(tbCc.Text);
                }
                //Bcc
                if(tbBcc.Text != "")
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
                    = new NetworkCredential(Set.MailAddress,Set.PassWord);
                smtpClient.Host = Set.Host;
                smtpClient.Port = Set.Port;
                smtpClient.EnableSsl = Set.SSL;
                //smtpClient.Send(mailMessage);
                string token = "SendMail";
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                smtpClient.SendAsync(mailMessage, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }
        }

        private void tbTo_TextChanged(object sender, EventArgs e)
        {
            btSend.Enabled = true;
        }
    }
}
