using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail
{
    public partial class SettingForm : Form
    {

        private Settings Set = Settings.getInstance();
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
            cbSSL.Checked = Set.bSSL();
            tbSender.Text = Set.sMailAddress();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //反映&ウィンド閉
        private void btOK_Click(object sender, EventArgs e)
        {
            SettingRegist();
            this.Close();
        }
        //反映
        private void btAdaption_Click(object sender, EventArgs e)
        {
            SettingRegist();
        }

        private void SettingRegist()
        {
            Set.Host = tbHost.Text;
            Set.Port = int.Parse(tbPort.Text);
            Set.PassWord = tbPassWord.Text;
            Set.MailAddress = tbSender.Text;
            Set.SSL = cbSSL.Checked;
            Set.UserName = tbSender.Text;

            //シリアル化
            /*var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "",
            };

            using (var writer = XmlWriter.Create(Set.File, xws))
            {
                var serializer = new DataContractSerializer(Set.GetType());
                serializer.WriteObject(writer, Set);
            }*/
            Set.Serializer();
            
        }
    }
}
