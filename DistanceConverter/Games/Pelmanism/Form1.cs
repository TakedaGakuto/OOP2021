using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism
{

    public partial class FormGame : Form
    {
        private Card[] playingCards;
        private Player player;
        private int gameSec;

        public FormGame()
        {
            InitializeComponent();
        }

        //カードの生成
        //cards(仮引数):カード配列への参照 
        private void CreateCards(ref Card[] cards)
        {
            string[] picture =
            {
                "〇","●","△","▲","□","■","◇","◆","☆","★","※","×",
            };

            //カードインスタンス生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //カード生成
            CreateCards(ref playingCards);

            //プレイヤー生成
            player = new Player();

            //カードの動的配置
            SuspendLayout();

            const int offsetX = 30, offsetY = 50;
            for (int i = 0; i < playingCards.Length; i++)
            {
                //カード(ボタン)プロパティ設定
                playingCards[i].Name = "card" + 1;
                int sizeW = playingCards[1].Size.Width;
                int sizeH = playingCards[1].Size.Height;
                playingCards[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i / 8 * sizeH);

                playingCards[i].Click += CarsButtons_Click;
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください。";

        }

        private void CarsButtons_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
