using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[] {
            new Song("あいうえお", "かきくけこ", 200),
            new Song("あいうえお", "かきくけこ", 200),
            new Song("あいうえお", "かきくけこ", 200)
            };
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach(var song in songs) {
                Console.WriteLine("タイトル:{0}",song.Title);
                Console.WriteLine("アーティスト名:{0}", song.ArtistName);
                Console.WriteLine("演奏時間:{0}:{1}",song.Length/60,song.Length%60);
            }
        }
    }
}
