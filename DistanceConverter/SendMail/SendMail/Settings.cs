using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null;
        public string Host { get; set; }        //ホスト名
        public int Port { get; set; }           //ポート番号
        public string PassWord { get; set; }    //パスワード
        public bool SSL { get; set; }            //SSL有無
        public string MailAddress { get; set; } //メールアドレス
        public string UserName { get; set; }    //ユーザー名

        //XMLファイル
        public string FileName { get; set; } = "mail.xml";

        bool ans = true;

        //コンストラクタ
        private Settings() { }

        public static Settings getInstance()
        {
            if (instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }

        public bool FileCheck()
        {
            if (File.Exists(this.FileName))
            {
                reSelializer();
                if (ans != false)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //シリアル化
        public void Serializer()
        {
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "",
            };
            using (var writer = XmlWriter.Create(this.FileName, xws))
            {
                var serializer = new DataContractSerializer(this.GetType());
                serializer.WriteObject(writer, this);
            }
        }

        //逆シリアライズ
        public void reSelializer()
        {
            using (var reader = XmlReader.Create(this.FileName))
            {
                try
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    var mail = serializer.ReadObject(reader) as Settings;

                    instance = mail;

                    //settingsへの登録
                    this.Port = mail.Port;
                    this.Host = mail.Host;
                    this.PassWord = mail.PassWord;
                    this.SSL = mail.SSL;
                    this.MailAddress = mail.MailAddress;
                    this.UserName = mail.UserName;
                }
                catch (Exception e)
                {
                    ans = false;
                }
            }
        }
        //初期値設定
        public string sHost()
        {
            return "smtp.gmail.com";
        }
        public string sPort()
        {
            return 587.ToString();
        }
        
        public string sPassWord()
        {
            return "Infosys2021";
        }
        public string sMailAddress()
        {
            return "ojsinfosys01@gmail.com";
        }
        public bool bSSL()
        {
            return true;
        }
    }
}