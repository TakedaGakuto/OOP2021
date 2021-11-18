using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Pelmanism
{
    //カードクラス
    class Card : Button
    {
        //カードのサイズ
        private const int SizeW = 50, SizeH = 70;

        //絵柄
        public String Picture { get; set; }
        //状態(True:表 False:裏)
        public bool State { get; set; }
        //表面の色
        public Color OpenColor { get; } = Color.White;
        //裏面の色
        public Color CloseColor { get; } = Color.LightSeaGreen;

        public Card(string picture)
        {
            Picture = picture;
            State = false;
            Size = new Size(SizeW, SizeH);
            BackColor = CloseColor;
            Font = new Font("MS UI Goshic", 14, FontStyle.Bold);
            Enabled = false;
        }

        //カードオープン
        public void Open()
        {
            State = true;
            BackColor = OpenColor;
            Text = Picture;
            Enabled = false;
        }

        //カードクローズ
        public void Close()
        {
            State = false;
            BackColor = CloseColor;
            Text = "";
            Enabled = true;
        }

        public void Turn()
        {
            if (State)
                Close();
            else
                Open();
        }
    }
}
