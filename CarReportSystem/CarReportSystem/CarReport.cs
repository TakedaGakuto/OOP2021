using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CarReportSystem {
    [Serializable]
    public class CarReport {
        [DisplayName("日付")]
        public DateTime Date { get; set; }
        [DisplayName("記録者")]
        public string EditorName { get; set; }
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }
        [DisplayName("車名")]
        public string CarName { get; set; }
        [DisplayName("レポート")]
        public string Report { get; set; }
        [DisplayName("写真")]
        public Image Picture { get; set; }

        //メーカー
        public enum MakerGroup {
            トヨタ, 日産, ホンダ, スバル, 外車, その他,
        }
        public void UpData(DateTime date,string EditorName,MakerGroup maker,string carName,string report,Image Pictire){
            this.Date = date;
            this.EditorName = EditorName;
            this.Maker = maker;
            this.CarName = carName;
            this.Report = report;
            this.Picture = Picture;

        }
    }
}
