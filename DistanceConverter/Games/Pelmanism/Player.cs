using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelmanism
{
    class Player
    {
        private int nowOpenCardIndex1; //1枚目
        private int nowOpenCardIndex2;//２枚目

        //前回の１枚目の添え字
        public int BeforeOpenCardIndex1 { get; set; }
        //前回の2 枚目の添え字
        public int BeforeOpenCardIndex2 { get; set; }

        //枚数
        public int OpenCounter { get; set; }

        //コンストラクタ
        public Player()
        {
            //初期化
            NowOpenCardIndex1 = NowOpenCardIndex2 = -1;
            BeforeOpenCardIndex1 = BeforeOpenCardIndex2 = -1;
            OpenCounter = 0;
        }

        //今回の1枚目の添え字
        public int NowOpenCardIndex1
        {
            get { return nowOpenCardIndex1; }
            set
            {
                nowOpenCardIndex1 = value;
                OpenCounter++;
            }
        }

        //今回の2枚目の添え字
        public int NowOpenCardIndex2
        {
            get { return nowOpenCardIndex2; }
            set
            {
                nowOpenCardIndex2 = value;
                OpenCounter++;
            }
        }

        //カードリセット
        public void Reset()
        {
            BeforeOpenCardIndex1 = NowOpenCardIndex1;
            BeforeOpenCardIndex2 = NowOpenCardIndex2;
            NowOpenCardIndex1 = -1;
            NowOpenCardIndex2 = -1;
            OpenCounter = 0;
        }
    }
}
