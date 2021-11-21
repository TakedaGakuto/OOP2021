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

        /// <summary>
        /// カードの生成
        /// </summary>
        /// <param name="cards">カード配列への参照</param>
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
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[1].Size.Width;
                int sizeH = playingCards[1].Size.Height;
                playingCards[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i / 8 * sizeH);

                playingCards[i].Click += CardButtons_Click;
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください。";

        }

        private void CardButtons_Click(object sender, EventArgs e)
        {
            //何枚目か
            if(player.OpenCounter == 0)
            {
                //前回不一致なら伏せる
                int b1 = player.BeforeOpenCardIndex1;
                int b2 = player.BeforeOpenCardIndex2;
                if(b1 != -1 && b2 != -1 && MatchCard(playingCards,b1,b2))
                {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }

                //クリックしたボタンの名前から添え字取得
                int n1 = int.Parse(((Button)sender).Name.Substring(4));

                //１枚目取得
                playingCards[n1].Open();
                player.NowOpenCardIndex1 = n1;

                labelGuidance.Text = " もう一枚目めくってください。";
                
            }
            else if(player.OpenCounter == 1)
            {
                int n2 = int.Parse(((Button)sender).Name.Substring(4));
                //2枚目
                playingCards[n2].Open();
                player.NowOpenCardIndex2 = n2;

                //一枚目と二枚目比較
                if (MatchCard(playingCards, player.NowOpenCardIndex1, player.NowOpenCardIndex2))
                {
                    labelGuidance.Text = "カードは不一致です。次のカードをめくってください。";
                }
                else{
                    labelGuidance.Text = "カードは一致しました。次のカードをめくってください";
                }
                //リセット
                player.Reset();

                //全カードをめくったか
                if (AllOpenCard(playingCards))
                {
                    labelGuidance.Text = "全部のカードが一致しました。お疲れ様でした。";
                    timer1.Stop();
                    buttonStart.Enabled = true;
                }
            }
        }
        /// <summary>
        /// カードが全部開いたか
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <returns>false:一枚以上裏がある</returns>
        private bool AllOpenCard(Card[] playingCards)
        {
            foreach(var card in playingCards)
            {
                if (!card.State)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// カードの一致チェック
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <param name="nowOpenCardIndex1">一枚目の添え字</param>
        /// <param name="nowOpenCardIndex2">二枚目の添え字</param>
        /// <returns>true:一致 false:不一致</returns>
        private bool MatchCard(Card[] Cards, int index1, int index2)
        {
            if (index1 < 0 || index1 >= Cards.Length || index2 < 0 || index2 >= Cards.Length)
                return true;

            if (Cards[index1].Picture.Equals(Cards[index2].Picture))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //シャッフル
            ShuffleCard(playingCards);

            //全カードを伏せる
            foreach (var card in playingCards)
            {
                card.Close();
            }
            //スタートボタンマスク
            buttonStart.Enabled = false;
            gameSec = 0;
            timer1.Start();

            labelGuidance.Text = "クリックしてカードをめくってください。";
        }

        /// <summary>
        /// カードを混ぜる
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        private void ShuffleCard(Card[] playingCards)
        {
            Random r = new Random();
            //int[] nums = new int[playingCards.Length];
            var numhashset = new HashSet<int>();
            for (var i = 0; i < 24; i++)
            {
                 var num = r.Next(0, 23);
                if (numhashset.Add(num) != true)
                {
                    i--;
                }
                if (i >= 21)
                {
                    for(var j = 0; j < 24 ; j++)
                    {
                        if (numhashset.Contains(j)!=true)
                        {
                            numhashset.Add(j);
                            i++;
                        }
                    }
                }
            }
            int[] nums = numhashset.ToArray();
            string[] temp = new string[24];
            for(var i = 0; i < 24; i++)
            {
                temp[i] = playingCards[i].Picture;
            }
            for(var i = 0; i < 24; i++)
            {
                playingCards[nums[i]].Picture = temp[i];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameSec++;
            labelSec.Text = gameSec + "秒経過"; 
        }
    }
}

