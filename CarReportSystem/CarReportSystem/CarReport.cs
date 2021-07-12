using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
        public DateTime Date { get; set; }
        public string EditorName { get; set; }
        public MakerGroup Maker { get; set; }
        public string CarName { get; set; }
        public string Report { get; set; }
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
