using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public class Settings
    {
        public int Port { get; set; }           //ポート番号
        public string Host { get; set; }        //ホスト名
        public string PassWord { get; set; }    //パスワード
        public bool SSL{ get; set; }            //SSL有無

        public string MailAddress { get; set; } //メールアドレス   


        //初期値設定
        public string sHost()
        {
            return "smpt.gmail.com";
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
    }
}
